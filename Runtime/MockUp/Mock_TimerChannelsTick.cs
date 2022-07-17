using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mock_TimerChannelsTick : MonoBehaviour
{

    public AccessTimerOmiHookNotifyMono m_toTick;
    public DelayHolder[] delayToTick = new DelayHolder[0];

    [System.Serializable]
    public class DelayHolder {
        public DelayHolder(double timeBetween, params Action [] actions) {
            m_timeLeft = timeBetween;
            m_timeBetweenTick = timeBetween;
            for (int i = 0; i < actions.Length; i++)
            {
                m_tick += actions[i];
            }
        }
        public double m_timeBetweenTick = 1;
        public double m_timeLeft =1;
        public Action m_tick;

        public void RemoveTime(double time, out bool changed) {
            m_timeLeft -= time;
            if (m_timeLeft <= 0f) {
                m_timeLeft = m_timeBetweenTick;
                changed = true;
                return;
            }
            changed = false;
        }

    }
   
    void Update()
    {
        float t = Time.deltaTime;
        for (int i = 0; i < delayToTick.Length; i++)
        {
            if (delayToTick[i] != null && delayToTick[i].m_tick != null) { 
                delayToTick[i].RemoveTime(t, out bool changed);
                if (changed) {
                    delayToTick[i].m_tick();
                }
            }
        }
    }
    public long count;
    public void Inc() { count++; }

    private void Awake()
    {
        ResetDelayHolder();
    }
   
    [ContextMenu("Refresh")]
    private void ResetDelayHolder()
    {
        if (m_toTick == null || m_toTick == null)
            return;
        //Should be split in two but thread and unity thread but his code is a mock up.
        delayToTick = new DelayHolder[] {
              new DelayHolder(1f/60    , m_toTick . NotifyCycle_UnityThread_60FPS ),
              new DelayHolder(1f/30    , m_toTick . NotifyCycle_UnityThread_30FPS ),
              new DelayHolder(1f/20          , m_toTick .NotifyCycle_UnityThread_20FPS ),
              new DelayHolder(1f/10, m_toTick .NotifyCycle_UnityThread_10FPS ),
              new DelayHolder(1f/5,  m_toTick .NotifyCycle_UnityThread_5FPS ),
              new DelayHolder(1f/4,  m_toTick .NotifyCycle_UnityThread_4FPS ),
              new DelayHolder(1f/2,  m_toTick .NotifyCycle_UnityThread_2FPS ),
              new DelayHolder(1,     m_toTick . NotifyCycle_UnityThread_1Second ),
              new DelayHolder(5,     m_toTick . NotifyCycle_UnityThread_5Seconds ),
              new DelayHolder(10,    m_toTick . NotifyCycle_UnityThread_10Seconds ),
              new DelayHolder(20,    m_toTick . NotifyCycle_UnityThread_20Seconds ),
              new DelayHolder(30,    m_toTick . NotifyCycle_UnityThread_30Seconds ),
              new DelayHolder(60,    m_toTick . NotifyCycle_UnityThread_1Minutes ),
              new DelayHolder(300,   m_toTick . NotifyCycle_UnityThread_5Minutes ),
              new DelayHolder(600,   m_toTick . NotifyCycle_UnityThread_10Minutes ),
              new DelayHolder(900,  m_toTick .NotifyCycle_UnityThread_15Minutes )
        };
    }


}


public class ThreadClock {

    public Thread m_thread;
    public Mock_TimerChannelsTick.DelayHolder[] m_frequences;
    public I_NotifyToHookToTimeThreadCycleOMI m_target;
    public ThreadClock(I_NotifyToHookToTimeThreadCycleOMI target) {

        m_target = target;
        m_frequences = new Mock_TimerChannelsTick.DelayHolder[] {
              new Mock_TimerChannelsTick.DelayHolder(1f/60,m_target.NotifyCycle_Thread_60FPS   ),
              new Mock_TimerChannelsTick.DelayHolder(1f/30,m_target .NotifyCycle_Thread_30FPS  ),
              new Mock_TimerChannelsTick.DelayHolder(1f/20,m_target .NotifyCycle_Thread_20FPS  ),
              new Mock_TimerChannelsTick.DelayHolder(1f/10,m_target .NotifyCycle_Thread_10FPS  ),
              new Mock_TimerChannelsTick.DelayHolder(1f/5,m_target .NotifyCycle_Thread_5FPS    ),
              new Mock_TimerChannelsTick.DelayHolder(1f/4,m_target .NotifyCycle_Thread_4FPS    ),
              new Mock_TimerChannelsTick.DelayHolder(1f/2,m_target .NotifyCycle_Thread_2FPS    ),
              new Mock_TimerChannelsTick.DelayHolder(1,m_target .NotifyCycle_Thread_1Second    ),
              new Mock_TimerChannelsTick.DelayHolder(5,m_target .NotifyCycle_Thread_5Seconds   ),
              new Mock_TimerChannelsTick.DelayHolder(10,m_target .NotifyCycle_Thread_10Seconds ),
              new Mock_TimerChannelsTick.DelayHolder(20,m_target .NotifyCycle_Thread_20Seconds ),
              new Mock_TimerChannelsTick.DelayHolder(30,m_target .NotifyCycle_Thread_30Seconds ),
              new Mock_TimerChannelsTick.DelayHolder(60,m_target .NotifyCycle_Thread_1Minutes  ),
              new Mock_TimerChannelsTick.DelayHolder(300,m_target .NotifyCycle_Thread_5Minutes ),
              new Mock_TimerChannelsTick.DelayHolder(600,m_target .NotifyCycle_Thread_10Minutes),
              new Mock_TimerChannelsTick.DelayHolder(900,m_target .NotifyCycle_Thread_15Minutes)
        };
    }

    public void Start() {
        if (m_thread != null) {
            m_thread.Abort();
            m_thread = null;
        }
        m_thread = new Thread(ClockThread);
        m_thread.Start();
    }

    DateTime m_previous;
    DateTime m_now;
    private void ClockThread()
    {
        m_previous= DateTime.Now;
        m_now = DateTime.Now;
        while (true) {
            m_now = DateTime.Now;
        double t = (m_now-m_previous).TotalMilliseconds;
        for (int i = 0; i < m_frequences.Length; i++)
        {
            if (m_frequences[i] != null && m_frequences[i].m_tick != null)
            {
                    m_frequences[i].RemoveTime(t, out bool changed);
                if (changed)
                {
                    m_frequences[i].m_tick();
                }
            }
            }
            m_previous = m_now;
            Thread.Sleep(1);
        }
    }
}