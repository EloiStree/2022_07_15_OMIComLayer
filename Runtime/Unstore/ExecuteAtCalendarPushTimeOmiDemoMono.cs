using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteAtCalendarPushTimeOmiDemoMono : MonoBehaviour
{
    public QueueTaskOnOMICalenderMono m_executeAtDate;

    public string m_whatToExecute="log: Hello Calendar !!";

    [Header("At")]
    public int m_year;
    public int m_month;
    public int m_day;
    public int m_hour;
    public int m_minute;
    public int m_seconds;

    [Header("Repeat")]
    public long m_reapeatTimeMs=20000;

    [Header("Every Day")]
    public I_PushCommandToCalendarTime.DayOfTheWeek m_dayOfWeekTarget;
    public I_PushCommandToCalendarTime.Executor_TimeOfDay m_timeOfDay;

    [Header("Action")]
    public ClassicThreadTarget m_targetThread;

    [ContextMenu("Push at Date")]
    public void PushAtDate()
    {
        DateTime target = new DateTime(m_year, m_month, m_day, m_hour, m_minute, m_seconds);
        m_executeAtDate.ExecuteCalendarAtDate(in m_targetThread, in target, m_whatToExecute);
    }
    [ContextMenu("Push at Now +0s")]
    public void PushAtDate0S()
    {
        PushAtDateN(0);
}
[ContextMenu("Push at Now +5s")]
    public void PushAtDate5S()
    {
        PushAtDateN(5);
}
[ContextMenu("Push at Now +10s")]
    public void PushAtDate10S() { PushAtDateN(10); }
    [ContextMenu("Push at Now +30s")]
    public void PushAtDate30S() { PushAtDateN(30); }
        [ContextMenu("Push at Now +300s")]
    public void PushAtDate300S()  {
    PushAtDateN(300);
        }
        [ContextMenu("Push at Now +1800s")]
    public void PushAtDate1800S() {
    PushAtDateN(1800);
        }
        [ContextMenu("Push at Now +1hs")]
    public void PushAtDate3600S()  {
    PushAtDateN(3600);
        }

    public void PushAtDateN(float timeSeconds)
    {
        DateTime target = DateTime.Now.AddSeconds(timeSeconds);
        m_executeAtDate.ExecuteCalendarAtDate(in m_targetThread, in target, m_whatToExecute);
    }
    [ContextMenu("Push repeat")]
    public void PushRepeat()
    {
        DateTime target = new DateTime(m_year, m_month, m_day, m_hour, m_minute, m_seconds);
        m_executeAtDate.RepeatExecutionEvery(in m_targetThread, in target, in m_reapeatTimeMs, m_whatToExecute);
    }
    [ContextMenu("Push Day")]
    public void PushRepeatDaily()
    {
        m_executeAtDate.ExecuteCalendarEveryDayAt(in m_targetThread, in m_timeOfDay, m_whatToExecute);
    }
    [ContextMenu("Push Weak")]
    public void PushRepeatWeekly()
    {
        m_executeAtDate.ExecuteCalendarEveryWeekAt(in m_targetThread, in m_dayOfWeekTarget, in m_timeOfDay, m_whatToExecute);
    }

    private void Reset()
    {
        DateTime n = DateTime.Now;
        m_year = n.Year;
        m_month = n.Month;
        m_day = n.Day;
        m_hour = n.Hour;
        m_minute = n.Minute;
        m_seconds = n.Second;
        m_timeOfDay.m_hour_0_23 = (byte) n.Hour;
        m_timeOfDay.m_minute_0_59 = (byte) n.Minute;
        m_timeOfDay.m_second_0_59 = (byte) n.Second;
        m_timeOfDay.m_millisecond_0_999 = (byte) n.Millisecond;
    }
}
