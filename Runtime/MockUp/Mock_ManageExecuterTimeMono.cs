using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mock_ManageExecuterTimeMono : MonoBehaviour
{
    public Mock_TimeExecuterManager m_timeManager = new Mock_TimeExecuterManager();
    void Awake()
    {
        StaticTimeExecuterComBridge.SetTimeExecuter(m_timeManager);
    }
    void OnDestory()
    {
        StaticTimeExecuterComBridge.RemoveTimeExecuter();
    }
}

[System.Serializable]
public class Mock_TimeExecuterManager : I_PushCodeToExecuteOnThreads
{
    public ExecuteAtActionThreadMono m_executeQueue;

    public void AddBasedOnThread(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toCall)
    {
        if (thread == ClassicThreadTarget.UnityThread)
            m_executeQueue.AddTaskOnUnityThread(DateTime.Now, toCall.Invoke);
        else
            m_executeQueue.AddTaskOnThread(DateTime.Now, toCall.Invoke);
    }
    public void AddBasedOnThread(in ClassicThreadTarget thread, in DateTime date,  in I_PushCodeToExecuteOnThreads.ActionCall toCall)
    {
        if (thread == ClassicThreadTarget.UnityThread)
        {
           
            m_executeQueue.AddTaskOnUnityThread(in date, toCall.Invoke);
        }
        else {
                
            m_executeQueue.AddTaskOnThread(in date, toCall.Invoke);
        }
    }

    public void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        Debug.Log(string.Format("{0}: {1}-{2}", "Exe ExecuteAlmostDirectly ", thread, toDo));
        AddBasedOnThread(in thread, in toDo);
    }

    public void ExecuteASAP(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        Debug.Log(string.Format("{0}: {1}-{2}", "Exe ExecuteASAP ", thread, toDo));
        AddBasedOnThread(in thread, in toDo);
    }

    public void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        Debug.Log(string.Format("{0}: {1}-{2}-{3}", "Exe ExecuteAt ", time.ToString(), thread, toDo));
        AddBasedOnThread(in thread,in time,  in toDo);
    }

    public void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        AddBasedOnThread(in thread, in time, in toDo);
        Debug.Log(string.Format("{0}: {1}-{2}-{3}", "Exe Directly ", time.ToString(), thread, toDo));
    }

    public void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait, in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
       
        Debug.Log(string.Format("{0}: {1}-{2}-{3}-{4}", "Exe ExecuteGentlemanASAP", oneIfHurryZeroIsCanWait, timeInSeconds, thread, toDo)); 
        DateTime n = DateTime.Now.AddSeconds(timeInSeconds);
        AddBasedOnThread(in thread,  n, in toDo);
    }

    public void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        Debug.Log(string.Format( "{0}: {1}-{2}-{3}", "Exe ExecuteIn", timeInSeconds, thread, toDo));
        DateTime n = DateTime.Now.AddSeconds(timeInSeconds);
        AddBasedOnThread(in thread,  n, in toDo);
    }

    public void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        Debug.Log(string.Format("{0}: {1}-{2}-{3}", "Exe ExecuteInExactly", timeInSeconds, thread, toDo)); 
        DateTime n = DateTime.Now.AddSeconds(timeInSeconds);
        AddBasedOnThread(in thread,  n, in toDo);
    }
}

