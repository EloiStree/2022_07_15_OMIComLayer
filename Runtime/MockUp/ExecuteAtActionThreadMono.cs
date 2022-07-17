using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ExecuteAtActionThreadMono : MonoBehaviour
{


    public List<ExecuteAtDate> m_threadTask = new List<ExecuteAtDate>();
    public Queue<ExecuteAtDate> m_toAddThread = new Queue<ExecuteAtDate>();
    public int m_debugThreadCount;
    public List<ExecuteAtDate> m_unityThreadTask = new List<ExecuteAtDate>();
    public Queue<ExecuteAtDate> m_toAddUnityThread = new Queue<ExecuteAtDate>();
    public int m_debugUnityThreadCount;


    public void AddTaskOnThread(in DateTime date, in Action action)
    {
        m_toAddThread.Enqueue(new  ExecuteAtDate(in date, in action));
    }
    public void AddTaskOnUnityThread(in DateTime date, in  Action action)
    {
        m_toAddUnityThread.Enqueue(new ExecuteAtDate(in date, in action));
    }

    public System.Threading.ThreadPriority m_priority = System.Threading.ThreadPriority.Normal;
    public int m_threadWaitTime = 1;
    Thread t;
    public bool m_threadMustLive = true;
    private void Awake()
    {
        t= new Thread(LoopCheck);
        t.Priority = m_priority;
        t.Start();
    }
    private void OnDestroy()
    {
        m_threadMustLive = false;
    }
    public void Update()
    {
        if (m_unityThreadTask.Count > 0 || m_toAddUnityThread.Count>0)
            CheckForPastDate_ToCallFromUnityThread();
    }

    public void LoopCheck()
    {
        while (m_threadMustLive) { 
            if(m_threadTask.Count > 0 || m_toAddThread.Count > 0) 
                CheckForPastDate_ToCallFromThread();
            Thread.Sleep(m_threadWaitTime);
        }
    }

    public void CheckForPastDate_ToCallFromThread() {

        while (m_toAddThread.Count > 0) { 
            m_threadTask.Insert(0, m_toAddThread.Dequeue());
            m_debugThreadCount = m_threadTask.Count;
        }
        CheckExecuteAndRemove(ref m_threadTask);
    }
    public void CheckForPastDate_ToCallFromUnityThread()
    {
        while (m_toAddUnityThread.Count > 0) { 
            m_unityThreadTask.Insert(0, m_toAddUnityThread.Dequeue());
            m_debugUnityThreadCount = m_unityThreadTask.Count;
        }
        CheckExecuteAndRemove(ref m_unityThreadTask);
    }
    private void CheckExecuteAndRemove(ref List<ExecuteAtDate> target)
    {
        DateTime now = DateTime.Now;
        for (int i = target.Count-1 ; i > -1; i--)
        {
            if (target[i].IsDatePast(in now)) {
                target[i].Invoke();
               // Debug.Log("Invoked! " + target[i].m_actionToCall);
                target.RemoveAt(i);
            }
        }
    }

    

    public struct ExecuteAtDate {
        public DateTime m_date;
        public Action m_actionToCall;
        public bool isPast ;
        public ExecuteAtDate(in DateTime date, in Action actionToCall)
        {
            if (date == null)
                m_date = DateTime.Now;
            else 
                m_date = date;
            m_actionToCall = actionToCall;
            isPast = false;
        }

        public bool IsDatePast(in DateTime now) { return m_date < now; }
        public void Invoke() {if(m_actionToCall!=null) m_actionToCall.Invoke(); }
        public bool IsDatePastInvoke(in DateTime now) {
            isPast= m_date < now;
            if (isPast) Invoke();
            return isPast;
        }
    }
}
