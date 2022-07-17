using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// If every module try to create a thread to manage time it will be total mess.
/// And if every module try to use Update and coroutine the app will lose in performence
/// </summary>
public enum HookType : byte { Hook = 1, Unhook = 0 };
public enum TimeFrequenceType {
    _60FPS,
    _30FPS,
    _20FPS,
    _10FPS,
    _5FPS,
    _4FPS,
    _2FPS,
    _1Second,
    _5Seconds,
    _10Seconds,
    _20Seconds,
    _30Seconds,
    _1Minutes,
    _5Minutes,
    _10Minutes,
    _15Minutes
}

public interface I_HookToTimeThreadCycleOMI
{
    public void Hook_Thread(TimeFrequenceType frequence, HookType hook, Action hookCallback);
    public void Hook_UnityThread(TimeFrequenceType frequence, HookType hook, Action hookCallback);
    //Most command can to run on C# thread out of Unity but some can.
    public void Hook_Thread_60FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_30FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_20FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_10FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_5FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_4FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_2FPS(HookType hook, Action hookCallback);
    public void Hook_Thread_1Second(HookType hook, Action hookCallback);
    public void Hook_Thread_5Seconds(HookType hook, Action hookCallback);
    public void Hook_Thread_10Seconds(HookType hook, Action hookCallback);
    public void Hook_Thread_20Seconds(HookType hook, Action hookCallback);
    public void Hook_Thread_30Seconds(HookType hook, Action hookCallback);
    public void Hook_Thread_1Minutes(HookType hook, Action hookCallback);
    public void Hook_Thread_5Minutes(HookType hook, Action hookCallback);
    public void Hook_Thread_10Minutes(HookType hook, Action hookCallback);
    public void Hook_Thread_15Minutes(HookType hook, Action hookCallback);

    //Hook to Unity thread means to be dependant of the frame rate that is set to low when not focus.
    //But some are requested to be on the Unity Thread
    public void Hook_UnityThread_60FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_30FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_20FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_10FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_5FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_4FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_2FPS(HookType hook, Action hookCallback);
    public void Hook_UnityThread_1Second(HookType hook, Action hookCallback);
    public void Hook_UnityThread_5Seconds(HookType hook, Action hookCallback);
    public void Hook_UnityThread_10Seconds(HookType hook, Action hookCallback);
    public void Hook_UnityThread_20Seconds(HookType hook, Action hookCallback);
    public void Hook_UnityThread_30Seconds(HookType hook, Action hookCallback);
    public void Hook_UnityThread_1Minutes(HookType hook, Action hookCallback);
    public void Hook_UnityThread_5Minutes(HookType hook, Action hookCallback);
    public void Hook_UnityThread_10Minutes(HookType hook, Action hookCallback);
    public void Hook_UnityThread_15Minutes(HookType hook, Action hookCallback);


}
public interface I_NotifyToHookToTimeThreadCycleOMI {

    public void NotifyCycle_Thread_60FPS();
    public void NotifyCycle_Thread_30FPS();
    public void NotifyCycle_Thread_20FPS();
    public void NotifyCycle_Thread_10FPS();
    public void NotifyCycle_Thread_5FPS();
    public void NotifyCycle_Thread_4FPS();
    public void NotifyCycle_Thread_2FPS();
    public void NotifyCycle_Thread_1Second();
    public void NotifyCycle_Thread_5Seconds();
    public void NotifyCycle_Thread_10Seconds();
    public void NotifyCycle_Thread_20Seconds();
    public void NotifyCycle_Thread_30Seconds();
    public void NotifyCycle_Thread_1Minutes();
    public void NotifyCycle_Thread_5Minutes();
    public void NotifyCycle_Thread_10Minutes();
    public void NotifyCycle_Thread_15Minutes();

    public void NotifyCycle_UnityThread_60FPS();
    public void NotifyCycle_UnityThread_30FPS();
    public void NotifyCycle_UnityThread_20FPS();
    public void NotifyCycle_UnityThread_10FPS();
    public void NotifyCycle_UnityThread_5FPS();
    public void NotifyCycle_UnityThread_4FPS();
    public void NotifyCycle_UnityThread_2FPS();
    public void NotifyCycle_UnityThread_1Second();
    public void NotifyCycle_UnityThread_5Seconds();
    public void NotifyCycle_UnityThread_10Seconds();
    public void NotifyCycle_UnityThread_20Seconds();
    public void NotifyCycle_UnityThread_30Seconds();
    public void NotifyCycle_UnityThread_1Minutes();
    public void NotifyCycle_UnityThread_5Minutes();
    public void NotifyCycle_UnityThread_10Minutes();
    public void NotifyCycle_UnityThread_15Minutes();
}

/// <summary>
/// This interface allows to request an action to loop without having to have to implement the timer manager and the loop manager.
/// And without requesting to create a new thread for that.
/// </summary>
public interface I_HookTimeLoop
{
    public void Hook_Thread_LoopCallBack(in double timeInMilliseconds, in Action hookCallBack, bool triggerAtStart = true, bool triggerAtEnd = true);
    public void Hook_UnityThread_LoopCallBack(in double timeInMilliseconds, in Action hookCallBack, bool triggerAtStart = true, bool triggerAtEnd = true);
    public void Hook_Thread_LoopCallBack(in double timeInMilliseconds,in Action hookCallBack, in Action actionAtStart , in Action actionAtEnd );
    public void Hook_UnityThread_LoopCallBack(in double timeInMilliseconds, in Action hookCallBack, in Action actionAtStart, in Action actionAtEnd);
    public void Unhook_Thread_LoopCallBack(in Action hookCallBack);
    public void Unhook_UnityThread_LoopCallBack(in Action hookCallBack);
}

/// <summary>
/// Allow to push an action to call at an exact time without having to implement all what is behind.
/// </summary>
public interface I_PushTimeCallback {
    public void Hook_Thread_TimeCallBack(DateTime time, Action hookCallBack);
    public void Hook_UnityThread_TimeCallBack(DateTime time, Action hookCallBack);
}
