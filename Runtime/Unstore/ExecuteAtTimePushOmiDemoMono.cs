using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteAtTimePushOmiDemoMono : MonoBehaviour
{
    public QueueTaskOnOMIClockMono m_timeExecutor;

    [Header("At")]
    public int m_hour;
    public int m_minute;
    public int m_seconds;
    [Header("In")]
    public int m_inSeconds;


    [Header("Action")]
    public ClassicThreadTarget m_targetThread;
    public string m_toSay;
    public bool m_useAnonymeMethode;
    public void SayDefault() { Say(m_toSay); }
    public void Say(string text) {
        Debug.Log("Unity say: " + text);
    }

    [ContextMenu("Push As Anonyme At")]
    public void PushAsAnonymeAt()
    {
        DateTime now = DateTime.Now;
        DateTime target = new DateTime(now.Year, now.Month, now.Day, m_hour, m_minute, m_seconds);
        m_timeExecutor.ExecuteAt(target, in m_targetThread, () => { string s = m_toSay; Say(s); }
        );
    }
    [ContextMenu("Push As Call At")]
    public void PushAsAsCallAt()
    {
        DateTime now = DateTime.Now;
        DateTime target = new DateTime(now.Year, now.Month, now.Day, m_hour, m_minute, m_seconds);
        m_timeExecutor.ExecuteAt(target, in m_targetThread, SayDefault);
    }

    [ContextMenu("Push As Anonyme In")]
    public void PushAsAnonymeIn()
    {
        m_timeExecutor.ExecuteIn(m_inSeconds, in m_targetThread, () => { string s = m_toSay; Say(s); }
        );
    }
    [ContextMenu("Push As Call In")]
    public void PushAsAsCallIn()
    {
        m_timeExecutor.ExecuteIn(m_inSeconds, in m_targetThread, SayDefault);
    }
}
