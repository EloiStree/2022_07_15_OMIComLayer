using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AccessTimerOmiHookNotifyMono : MonoBehaviour, I_NotifyToHookToTimeThreadCycleOMI
{

    public void NotifyCycle_Thread_10FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_10FPS();

    public void NotifyCycle_Thread_10Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_10Minutes();

    public void NotifyCycle_Thread_10Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_10Seconds();

    public void NotifyCycle_Thread_15Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_15Minutes();

    public void NotifyCycle_Thread_1Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_1Minutes();

    public void NotifyCycle_Thread_1Second()
    {
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_1Second();
    }

    public void NotifyCycle_Thread_20FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_20FPS();

    public void NotifyCycle_Thread_20Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_20Seconds();

    public void NotifyCycle_Thread_2FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_2FPS();

    public void NotifyCycle_Thread_30FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_30FPS();

    public void NotifyCycle_Thread_30Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_30Seconds();

    public void NotifyCycle_Thread_4FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_4FPS();

    public void NotifyCycle_Thread_5FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_5FPS();

    public void NotifyCycle_Thread_5Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_5Minutes();

    public void NotifyCycle_Thread_5Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_5Seconds();

    public void NotifyCycle_Thread_60FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_Thread_60FPS();

    public void NotifyCycle_UnityThread_10FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_10FPS();

    public void NotifyCycle_UnityThread_10Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_10Minutes();

    public void NotifyCycle_UnityThread_10Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_10Seconds();

    public void NotifyCycle_UnityThread_15Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_15Minutes();

    public void NotifyCycle_UnityThread_1Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_1Minutes();

    public void NotifyCycle_UnityThread_1Second() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_1Second();

    public void NotifyCycle_UnityThread_20FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_20FPS();

    public void NotifyCycle_UnityThread_20Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_20Seconds();

    public void NotifyCycle_UnityThread_2FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_2FPS();

    public void NotifyCycle_UnityThread_30FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_30FPS();

    public void NotifyCycle_UnityThread_30Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_30Seconds();

    public void NotifyCycle_UnityThread_4FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_4FPS();

    public void NotifyCycle_UnityThread_5FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_5FPS();

    public void NotifyCycle_UnityThread_5Minutes() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_5Minutes();

    public void NotifyCycle_UnityThread_5Seconds() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_5Seconds();

    public void NotifyCycle_UnityThread_60FPS() =>
        HookTimeFacadeOMI.GetInstanceHookNotify().NotifyCycle_UnityThread_60FPS();
}

[System.Serializable]
public class HookAndNotifyToTimeThreadCycleOMI : AbstractHookAndNotifyToTimeThreadCycleOMISide
{
    public static void NotifyAction(Action actionUnityHolder)
    {
        if (actionUnityHolder != null ) {

            actionUnityHolder.Invoke();
        }
    }
    public static void NotifyUnityAction(UnityEvent actionUnityHolder)
    {
        if (actionUnityHolder != null)
            actionUnityHolder.Invoke();
    }

    public override void NotifyCycle_Thread_10FPS()
    {
        NotifyAction(m_thread_10FPS);
    }

    public override void NotifyCycle_Thread_10Minutes()
    {
        NotifyAction(m_thread_10Minutes);
    }

    public override void NotifyCycle_Thread_10Seconds()
    {
        NotifyAction(m_thread_10Seconds);
    }

    public override void NotifyCycle_Thread_15Minutes()
    {
        NotifyAction(m_thread_15Minutes);
    }

    public override void NotifyCycle_Thread_1Minutes()
    {
        NotifyAction(m_thread_1Minutes);
    }

    public override void NotifyCycle_Thread_1Second()
    {
        NotifyAction(m_thread_1Second);
    }

    public override void NotifyCycle_Thread_20FPS()
    {
        NotifyAction(m_thread_20FPS);
    }

    public override void NotifyCycle_Thread_20Seconds()
    {
        NotifyAction(m_thread_20Seconds);
    }

    public override void NotifyCycle_Thread_2FPS()
    {
        NotifyAction(m_thread_2FPS);
    }

    public override void NotifyCycle_Thread_30FPS()
    {
        NotifyAction(m_thread_30FPS);
    }

    public override void NotifyCycle_Thread_30Seconds()
    {
        NotifyAction(m_thread_30Seconds);
    }

    public override void NotifyCycle_Thread_4FPS()
    {
        NotifyAction(m_thread_4FPS);
    }

    public override void NotifyCycle_Thread_5FPS()
    {
        NotifyAction(m_thread_5FPS);
    }

    public override void NotifyCycle_Thread_5Minutes()
    {
        NotifyAction(m_thread_5Minutes);
    }

    public override void NotifyCycle_Thread_5Seconds()
    {
        NotifyAction(m_thread_5Seconds);
    }

    public override void NotifyCycle_Thread_60FPS()
    {
        NotifyAction(m_thread_60FPS);
    }

   

    public override void NotifyCycle_UnityThread_10FPS()
    {
        NotifyAction(m_unityThread_10FPS);
    }

    public override void NotifyCycle_UnityThread_10Minutes()
    {
        NotifyAction(m_unityThread_10Minutes);
    }

    public override void NotifyCycle_UnityThread_10Seconds()
    {
        NotifyAction(m_unityThread_10Seconds);
    }

    public override void NotifyCycle_UnityThread_15Minutes()
    {
        NotifyAction(m_unityThread_15Minutes);
    }

    public override void NotifyCycle_UnityThread_1Minutes()
    {
        NotifyAction(m_unityThread_1Minutes);
    }

    public override void NotifyCycle_UnityThread_1Second()
    {
        NotifyAction(m_unityThread_1Second);
    }

    public override void NotifyCycle_UnityThread_20FPS()
    {
        NotifyAction(m_unityThread_20FPS);
    }

    public override void NotifyCycle_UnityThread_20Seconds()
    {
        NotifyAction(m_unityThread_20Seconds);
    }

    public override void NotifyCycle_UnityThread_2FPS()
    {
        NotifyAction(m_unityThread_2FPS);
    }

    public override void NotifyCycle_UnityThread_30FPS()
    {
        NotifyAction(m_unityThread_30FPS);
    }

    public override void NotifyCycle_UnityThread_30Seconds()
    {
        NotifyAction(m_unityThread_30Seconds);
    }

    public override void NotifyCycle_UnityThread_4FPS()
    {
        NotifyAction(m_unityThread_4FPS);
    }

    public override void NotifyCycle_UnityThread_5FPS()
    {
        NotifyAction(m_unityThread_5FPS);
    }

    public override void NotifyCycle_UnityThread_5Minutes()
    {
        NotifyAction(m_unityThread_5Minutes);
    }

    public override void NotifyCycle_UnityThread_5Seconds()
    {
        NotifyAction(m_unityThread_5Seconds);
    }

    public override void NotifyCycle_UnityThread_60FPS()
    {
        NotifyAction(m_unityThread_60FPS);
    }
}

public abstract class AbstractHookAndNotifyToTimeThreadCycleOMISide : HookToTimeThreadCycleOMI, I_NotifyToHookToTimeThreadCycleOMI
{
   
    public abstract  void NotifyCycle_Thread_60FPS();
    public abstract  void NotifyCycle_Thread_30FPS();
    public abstract  void NotifyCycle_Thread_20FPS();
    public abstract  void NotifyCycle_Thread_10FPS();
    public abstract  void NotifyCycle_Thread_5FPS();
    public abstract  void NotifyCycle_Thread_4FPS();
    public abstract  void NotifyCycle_Thread_2FPS();
    public abstract  void NotifyCycle_Thread_1Second();
    public abstract  void NotifyCycle_Thread_5Seconds();
    public abstract  void NotifyCycle_Thread_10Seconds();
    public abstract  void NotifyCycle_Thread_20Seconds();
    public abstract  void NotifyCycle_Thread_30Seconds();
    public abstract  void NotifyCycle_Thread_1Minutes();
    public abstract  void NotifyCycle_Thread_5Minutes();
    public abstract  void NotifyCycle_Thread_10Minutes();
    public abstract  void NotifyCycle_Thread_15Minutes();

    public abstract  void NotifyCycle_UnityThread_60FPS();
    public abstract  void NotifyCycle_UnityThread_30FPS();
    public abstract  void NotifyCycle_UnityThread_20FPS();
    public abstract  void NotifyCycle_UnityThread_10FPS();
    public abstract  void NotifyCycle_UnityThread_5FPS();
    public abstract  void NotifyCycle_UnityThread_4FPS();
    public abstract  void NotifyCycle_UnityThread_2FPS();
    public abstract  void NotifyCycle_UnityThread_1Second();
    public abstract  void NotifyCycle_UnityThread_5Seconds();
    public abstract  void NotifyCycle_UnityThread_10Seconds();
    public abstract  void NotifyCycle_UnityThread_20Seconds();
    public abstract  void NotifyCycle_UnityThread_30Seconds();
    public abstract  void NotifyCycle_UnityThread_1Minutes();
    public abstract  void NotifyCycle_UnityThread_5Minutes();
    public abstract  void NotifyCycle_UnityThread_10Minutes();
    public abstract  void NotifyCycle_UnityThread_15Minutes();
}



[System.Serializable]
public abstract class HookToTimeThreadCycleOMI : AbstractHookToTimeThreadCycleOMISide
{
    public Action m_thread_10FPS;
    public Action m_thread_10Minutes;
    public Action m_thread_10Seconds;
    public Action m_thread_15Minutes;
    public Action m_thread_1Minutes;
    public Action m_thread_1Second;
    public Action m_thread_20FPS;
    public Action m_thread_20Seconds;
    public Action m_thread_2FPS;
    public Action m_thread_30FPS;
    public Action m_thread_30Seconds;
    public Action m_thread_4FPS;
    public Action m_thread_5FPS;
    public Action m_thread_5Minutes;
    public Action m_thread_5Seconds;
    public Action m_thread_60FPS;
    public Action m_thread_60Seconds;
    public Action m_unityThread_60FPS;
    public Action m_unityThread_30FPS;
    public Action m_unityThread_20FPS;
    public Action m_unityThread_10FPS;
    public Action m_unityThread_4FPS;
    public Action m_unityThread_5FPS;
    public Action m_unityThread_2FPS;
    public Action m_unityThread_1Second;
    public Action m_unityThread_5Seconds;
    public Action m_unityThread_10Seconds;
    public Action m_unityThread_20Seconds;
    public Action m_unityThread_30Seconds;
    public Action m_unityThread_1Minutes;
    public Action m_unityThread_5Minutes;
    public Action m_unityThread_10Minutes;
    public Action m_unityThread_15Minutes;

    public static void HookAction(HookType type, ref Action actionHolder, ref Action action)
    {
        if (type == HookType.Hook)
        {
            actionHolder += action.Invoke;
        }
        else {

            actionHolder -= action.Invoke;
        }
    }
    public static void HookUnityAction(HookType type, ref  UnityEvent actionUnityHolder, ref Action action)
    {
        if (type == HookType.Hook) actionUnityHolder.AddListener(action.Invoke);
        else actionUnityHolder.RemoveListener(action.Invoke);
    }
    

    public override void Hook_Thread_10FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_10FPS, ref hookCallback);
    }

    public override void Hook_Thread_10Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_10Minutes, ref hookCallback);
    }

    public override void Hook_Thread_10Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_10Seconds, ref hookCallback);
    }

    public override void Hook_Thread_15Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_15Minutes, ref hookCallback);
    }

    public override void Hook_Thread_1Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_1Minutes, ref hookCallback);
    }

    public override void Hook_Thread_1Second(HookType hook, Action hookCallback)
    {
            HookAction(hook, ref m_thread_1Second, ref hookCallback);
    }

    public override void Hook_Thread_20FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_20FPS, ref hookCallback);
    }

    public override void Hook_Thread_20Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_20Seconds, ref hookCallback);
    }

    public override void Hook_Thread_2FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_2FPS, ref hookCallback);
    }

    public override void Hook_Thread_30FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_30FPS, ref hookCallback);
    }

    public override void Hook_Thread_30Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_30Seconds, ref hookCallback);
    }

    public override void Hook_Thread_4FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_4FPS, ref hookCallback);
    }

    public override void Hook_Thread_5FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_5FPS, ref hookCallback);
    }

    public override void Hook_Thread_5Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_5Minutes, ref hookCallback);
    }

    public override void Hook_Thread_5Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_5Seconds, ref hookCallback);
    }
    
    public override void Hook_Thread_60FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_thread_60FPS, ref hookCallback);
    }
    

    
    public override void Hook_UnityThread_10FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_10FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_10Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_10Minutes, ref hookCallback);
    }
    
    public override void Hook_UnityThread_10Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_10Seconds, ref hookCallback);
    }
    
    public override void Hook_UnityThread_15Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_15Minutes, ref hookCallback);
    }
    
    public override void Hook_UnityThread_1Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_1Minutes, ref hookCallback);
    }
    
    public override void Hook_UnityThread_1Second(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_1Second, ref hookCallback);
    }
    
    public override void Hook_UnityThread_20FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_20FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_20Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_20Seconds, ref hookCallback);
    }
    
    public override void Hook_UnityThread_2FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_2FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_30FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_30FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_30Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_30Seconds, ref hookCallback);
    }
    
    public override void Hook_UnityThread_4FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_4FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_5FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_5FPS, ref hookCallback);
    }
    
    public override void Hook_UnityThread_5Minutes(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_5Minutes, ref hookCallback);
    }
    
    public override void Hook_UnityThread_5Seconds(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_5Seconds, ref hookCallback);
    }
    
    public override void Hook_UnityThread_60FPS(HookType hook, Action hookCallback)
    {
        HookAction(hook, ref m_unityThread_60FPS, ref hookCallback);
    }
}

[System.Serializable]
public class HookToTimeThreadCycleOMIBasicOnly 
{

    public int m_threadQueueCount;
    public List<ToDo> m_toDoThread = new List<ToDo>();
    public int m_unityThreadQueueCount;
    public List<ToDo> m_toDoUnityThread = new List<ToDo>();

    public class ToDo {
        public DateTime m_time;
        public Action m_action;

        public ToDo(DateTime time, Action hookCallBack)
        {
            this.m_time = time;
            this.m_action = hookCallBack;
        }
    }

    public void PushIfOutOfDate( in List<ToDo> toDo, DateTime now) {
        for (int i = toDo.Count-1; i >= 0; i--)
        {
            if (toDo[i].m_time < now) {
                toDo[i].m_action.Invoke();
                toDo.RemoveAt(i);
            }
        }
    }
    public void CheckThreadAndPush() { PushIfOutOfDate(in m_toDoThread, DateTime.Now);
        m_threadQueueCount = m_toDoThread.Count;
    }
    public void CheckUnityThreadAndPush() { PushIfOutOfDate(in m_toDoUnityThread, DateTime.Now);
        m_unityThreadQueueCount = m_toDoUnityThread.Count;
            }

    //public override void Hook_Thread_TimeCallBack(DateTime time, Action hookCallBack)
    //{       m_toDoThread.Add(new ToDo(time, hookCallBack));    }
    //public override void Hook_UnityThread_TimeCallBack(DateTime time, Action hookCallBack)
    //{       m_toDoUnityThread.Add(new ToDo(time, hookCallBack));    }

    
    //public override void Hook_Thread_LoopCallBack(double timeInMilliseconds, Action hookCallBack, bool triggerAtStart = true, bool triggerAtEnd = true){}
    //public override void Hook_UnityThread_LoopCallBack(double timeInMilliseconds, Action hookCallBack, bool triggerAtStart = true, bool triggerAtEnd = true){}
    //public override void Unhook_Thread_LoopCallBack(Action hookCallBack){}
    //public override void Unhook_UnityThread_LoopCallBack(Action hookCallBack){}
}



public abstract class AbstractHookToTimeThreadCycleOMISide : I_HookToTimeThreadCycleOMI
{

    //Most command can to run on C# thread out of Unity but some can.
    public abstract void Hook_Thread_60FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_30FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_20FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_10FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_5FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_4FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_2FPS(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_1Second(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_5Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_10Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_20Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_30Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_1Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_5Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_10Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_Thread_15Minutes(HookType hook, Action hookCallback);

    //Hook to Unity thread means to be dependant of the frame rate that is set to low when not focus.
    //But some are requested to be on the Unity Thread
    public abstract void Hook_UnityThread_60FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_30FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_20FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_10FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_5FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_4FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_2FPS(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_1Second(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_5Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_10Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_20Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_30Seconds(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_1Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_5Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_10Minutes(HookType hook, Action hookCallback);
    public abstract void Hook_UnityThread_15Minutes(HookType hook, Action hookCallback);

    public void Hook_Thread(TimeFrequenceType frequence, HookType hook, Action hookCallback)
    {
        switch (frequence)
        {
            case TimeFrequenceType._60FPS:     Hook_Thread_60FPS(hook, hookCallback);     break;
            case TimeFrequenceType._30FPS:     Hook_Thread_30FPS(hook, hookCallback);     break;
            case TimeFrequenceType._20FPS:     Hook_Thread_20FPS(hook, hookCallback);     break;
            case TimeFrequenceType._10FPS:     Hook_Thread_10FPS(hook, hookCallback);     break;
            case TimeFrequenceType._5FPS:      Hook_Thread_5FPS(hook, hookCallback);      break;
            case TimeFrequenceType._4FPS:      Hook_Thread_4FPS(hook, hookCallback);      break;
            case TimeFrequenceType._2FPS:      Hook_Thread_2FPS(hook, hookCallback);      break;
            case TimeFrequenceType._1Second:   Hook_Thread_1Second(hook, hookCallback);   break;
            case TimeFrequenceType._5Seconds:  Hook_Thread_5Seconds(hook, hookCallback);  break;
            case TimeFrequenceType._10Seconds: Hook_Thread_10Seconds(hook, hookCallback); break;
            case TimeFrequenceType._20Seconds: Hook_Thread_20Seconds(hook, hookCallback); break;
            case TimeFrequenceType._30Seconds: Hook_Thread_30Seconds(hook, hookCallback); break;
            case TimeFrequenceType._1Minutes:  Hook_Thread_1Minutes(hook, hookCallback);  break;
            case TimeFrequenceType._5Minutes:  Hook_Thread_5Minutes(hook, hookCallback);  break;
            case TimeFrequenceType._10Minutes: Hook_Thread_10Minutes(hook, hookCallback); break;
            case TimeFrequenceType._15Minutes: Hook_Thread_15Minutes(hook, hookCallback); break;
            default:
                break;
        }
    }

    public void Hook_UnityThread(TimeFrequenceType frequence, HookType hook, Action hookCallback)
    {
        switch (frequence)
        {
            case TimeFrequenceType._60FPS:     Hook_UnityThread_60FPS(hook, hookCallback);     break;
            case TimeFrequenceType._30FPS:     Hook_UnityThread_30FPS(hook, hookCallback);     break;
            case TimeFrequenceType._20FPS:     Hook_UnityThread_20FPS(hook, hookCallback);     break;
            case TimeFrequenceType._10FPS:     Hook_UnityThread_10FPS(hook, hookCallback);     break;
            case TimeFrequenceType._5FPS:      Hook_UnityThread_5FPS(hook, hookCallback);      break;
            case TimeFrequenceType._4FPS:      Hook_UnityThread_4FPS(hook, hookCallback);      break;
            case TimeFrequenceType._2FPS:      Hook_UnityThread_2FPS(hook, hookCallback);      break;
            case TimeFrequenceType._1Second:   Hook_UnityThread_1Second(hook, hookCallback);   break;
            case TimeFrequenceType._5Seconds:  Hook_UnityThread_5Seconds(hook, hookCallback);  break;
            case TimeFrequenceType._10Seconds: Hook_UnityThread_10Seconds(hook, hookCallback); break;
            case TimeFrequenceType._20Seconds: Hook_UnityThread_20Seconds(hook, hookCallback); break;
            case TimeFrequenceType._30Seconds: Hook_UnityThread_30Seconds(hook, hookCallback); break;
            case TimeFrequenceType._1Minutes:  Hook_UnityThread_1Minutes(hook, hookCallback);  break;
            case TimeFrequenceType._5Minutes:  Hook_UnityThread_5Minutes(hook, hookCallback);  break;
            case TimeFrequenceType._10Minutes: Hook_UnityThread_10Minutes(hook, hookCallback); break;
            case TimeFrequenceType._15Minutes: Hook_UnityThread_15Minutes(hook, hookCallback); break;
            default:
                break;
        }
    }
}