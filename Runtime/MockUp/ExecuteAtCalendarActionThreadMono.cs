using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteAtCalendarActionThreadMono : MonoBehaviour
{

    public ExecuteAtActionThreadMono m_timeExecuter;
    public double m_defaultTime = 90;
    public bool m_useCoroutineDefaultTime=true;
    public float m_coroutineTimeCheck = 15;
    public void PushCommandLine(in string line) { }

    public List<ExecuteAtDateCommandLine> m_waitToBeImportantList = new List<ExecuteAtDateCommandLine>();
    public Queue<ExecuteAtDateCommandLine> m_toAdd= new Queue<ExecuteAtDateCommandLine>();
    public int m_debugWaiting;
    public int m_debugQueue;
    private void Awake()
    {
        if (m_useCoroutineDefaultTime) InvokeRepeating("CheckIfSomeAreExcutableUnderDefaultTime", 0, m_coroutineTimeCheck);
    }

    public void AddInQueue(in ClassicThreadTarget thread, in DateTime date, in string commandline)
    {
        m_toAdd.Enqueue( new ExecuteAtDateCommandLine(in thread,in date, in commandline) );
        m_debugQueue = m_toAdd.Count;
    }


    public void CheckIfSomeAreExcutableUnder5minutes()
        => CheckIfSomeAreExcutableUnderNSeconds(300.0);
    public void CheckIfSomeAreExcutableUnderDefaultTime()
        => CheckIfSomeAreExcutableUnderNSeconds(m_defaultTime);

    public void CheckIfSomeAreExcutableUnderNSeconds(double secondsToBeActive)
    {
        while (m_toAdd.Count > 0)
        {
            m_waitToBeImportantList.Insert(0, m_toAdd.Dequeue());
            m_debugWaiting = m_waitToBeImportantList.Count;

            Debug.Log("hook long overwatch");
        }
        DateTime now = DateTime.Now.AddSeconds(secondsToBeActive);
        for (int i = m_waitToBeImportantList.Count - 1; i > -1; i--)
        {
            if (m_waitToBeImportantList[i].IsDatePast(in now))
            {
                UnhookToTimeExecuter(m_waitToBeImportantList[i]);
                m_waitToBeImportantList.RemoveAt(i);
            }
        }
    }
    public void UnhookToTimeExecuter(in ExecuteAtDateCommandLine info)
    {
        Debug.Log("Unhook");
        DateTime d = new DateTime(info.m_asLongDateTick);
        string line = info.GetCommandLine();
        if (info.m_threadTime == ClassicThreadTarget.UnityThread)
        {
            m_timeExecuter.AddTaskOnUnityThread(in d, () => PushCommandLine(line));
        }else
        {
            m_timeExecuter.AddTaskOnThread(in d, () => PushCommandLine(line));
        }
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

}