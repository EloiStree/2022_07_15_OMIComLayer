using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class ExecuteAtCalendarActionThreadMono : MonoBehaviour
{

    [TextArea(0, 3)]
    public string m_developNote = "You need too hook a listener but consider that some command are from none unity thread.";
    public Action<string> m_onCommandLinePushed;
    public void AddListenerToRelayTheCommandLine(in Action<string> listener) => m_onCommandLinePushed += listener.Invoke;
    public void RemoveListenerToRelayTheCommandLine(in Action<string> listener) => m_onCommandLinePushed -= listener.Invoke;


    [System.Serializable]
    public class StringEvent : UnityEvent<string> { };

    public ExecuteAtActionThreadMono m_timeExecuter;
    public double m_activationTimeSecondsBeforeUsed = 90;
    public bool m_useCoroutineDefaultTime = true;
    public float m_coroutineTimeCheck = 15;
    public void PushCommandLine(in string line)
    {
        if(m_onCommandLinePushed!=null)
            m_onCommandLinePushed.Invoke(line);

        Debug.Log("Pushed");
    }

    public List<ExecuteAtDateCommandLine> m_waitToBeImportantList = new List<ExecuteAtDateCommandLine>();
    public Queue<ExecuteAtDateCommandLine> m_toAdd = new Queue<ExecuteAtDateCommandLine>();
    public int m_debugWaiting;
    public int m_debugQueue;
    private void Awake()
    {
        if (m_useCoroutineDefaultTime) 
            InvokeRepeating("CheckIfSomeAreExcutableUnderDefaultTime", 0, m_coroutineTimeCheck);
        m_onCommandLinePushed += Log;
        LoadInfo();
    }

    private void OnDestroy()
    {
        SaveInfo();
    }

    private void SaveInfo()
    {
        FlushQueue();
        string json = JsonUtility.ToJson(m_waitToBeImportantList);
        File.WriteAllText(GetAppDataPathFile(), json);
    }
    string GetAppDataPathFile() {  return Application.persistentDataPath + "/TempDataCommandSave.json"; }

    [ContextMenu("Open AppData")]
    public void OpenAppData() {
        Application.OpenURL(GetAppDataPathFile());
    }

    private void FlushQueue()
    {
        while (m_toAdd.Count > 0)
        {
            m_waitToBeImportantList.Insert(0, m_toAdd.Dequeue());
            m_debugWaiting = m_waitToBeImportantList.Count;
        }
    }


    [ContextMenu("Remove All Waiting")]
    public void RemoveAllWaiting()
    {
        m_waitToBeImportantList.Clear();
        m_toAdd.Clear();
    }

    private void LoadInfo() {
        if (!File.Exists(GetAppDataPathFile()))
            return;
        string json = File.ReadAllText(GetAppDataPathFile());
        if (string.IsNullOrWhiteSpace(json))
            return;
        List<ExecuteAtDateCommandLine> tt = JsonUtility.FromJson<List<ExecuteAtDateCommandLine>>(json);
        DateTime now = DateTime.Now;
        for (int i = tt.Count - 1; i > -1; i--)
        {
            if (tt[i].IsDatePast(in now))
            {
                tt.RemoveAt(i);
            }
        }
        m_waitToBeImportantList.AddRange(tt);

    }
    public bool m_calendarSleepMode=false;
    public void SetInPauseMode(bool trueSleepFalseActive)
    {
        m_calendarSleepMode = trueSleepFalseActive;
    }
    public void SetCalendarAsActive(bool isActive)
    {
        m_calendarSleepMode = !isActive;
    }

    public void AddInQueue(in ClassicThreadTarget thread, in DateTime date, in string commandline)
    {
        ExecuteAtDateCommandLine eDate = new ExecuteAtDateCommandLine(in thread, in date, in commandline);
        if (m_calendarSleepMode)
        {
            m_toAdd.Enqueue(eDate);
            RefreshCount();
        }
        else {
            ChechDateBeforeQueueFor(ref eDate, out bool pushed);
            if (!pushed)
            {
                m_toAdd.Enqueue(eDate);
                RefreshCount();
            }
        }

        
    }
    public void RefreshCount() {

        m_debugWaiting = m_waitToBeImportantList.Count;
        m_debugQueue = m_toAdd.Count;
    }


    public void CheckIfSomeAreExcutableUnder5minutes()
        => CheckIfSomeAreExcutableUnderNSeconds(300.0);
    public void CheckIfSomeAreExcutableUnderDefaultTime()
        => CheckIfSomeAreExcutableUnderNSeconds(m_activationTimeSecondsBeforeUsed);

    public void CheckIfSomeAreExcutableUnderNSeconds(double secondsToBeActive)
    {
        FlushQueue();
        if (m_calendarSleepMode)
            return;
        DateTime willBeNow = DateTime.Now.AddSeconds(secondsToBeActive);
        DateTime now = DateTime.Now;
        for (int i = m_waitToBeImportantList.Count - 1; i > -1; i--)
        {
            ChechDateFor(ref willBeNow, ref now, ref i);
        }
    }

    private void ChechDateFor(ref DateTime willBeNow, ref DateTime now, ref int i)
    {
        if (m_waitToBeImportantList[i].IsDatePast(in willBeNow) || m_waitToBeImportantList[i].IsDatePast(in now))
        {
            UnhookToTimeExecuter(m_waitToBeImportantList[i]);
            m_waitToBeImportantList.RemoveAt(i);
        }
    }
    private void ChechDateBeforeQueueFor(ref ExecuteAtDateCommandLine toExecute, out bool pushed)
    {
        DateTime willBeNow = DateTime.Now.AddSeconds(m_activationTimeSecondsBeforeUsed);
        DateTime now = DateTime.Now;
        if (toExecute.IsDatePast(in willBeNow) || toExecute.IsDatePast(in now))
        {
            UnhookToTimeExecuter(toExecute);
            pushed = true;
            return;
        }
        pushed = false;
    }

    public void UnhookToTimeExecuter(in ExecuteAtDateCommandLine info)
    {
        DateTime d = new DateTime(info.m_asLongDateTick);
        string line = info.GetCommandLine();
        if (info.m_threadTime == ClassicThreadTarget.UnityThread)
        {
            m_timeExecuter.AddTaskOnUnityThread(in d, () => PushCommandLine(line));
        } else
        {
            m_timeExecuter.AddTaskOnThread(in d, () => PushCommandLine(line));
        }
        RefreshCount();
    }




    [System.Serializable]
    public struct ExecuteAtDateCommandLine
    {
        public long m_asLongDateTick;
        public ClassicThreadTarget m_threadTime;
        public string m_commandLineToPush;
        public ExecuteAtDateCommandLine(in ClassicThreadTarget thread, in DateTime date, in string commandline)
        {
            m_threadTime = thread;
            if (date == null)
                m_asLongDateTick = DateTime.Now.Ticks;
            else
                m_asLongDateTick = date.Ticks;
            m_commandLineToPush = commandline;
        }

        public bool IsDatePast(in DateTime now) { return m_asLongDateTick < now.Ticks; }
        public string GetCommandLine() { return m_commandLineToPush; }
        public ClassicThreadTarget GetThreadType() { return m_threadTime; }
    }

    public void Log(string message) { Debug.Log("> >" + message); }

}