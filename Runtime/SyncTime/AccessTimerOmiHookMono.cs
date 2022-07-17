using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessTimerOmiHookMono : MonoBehaviour, I_HookToTimeThreadCycleOMI
{

    public bool IsStaticInstanceDefine() { return HookTimeFacadeOMI.GetInstanceHook() != null; }
    public void Hook_Thread_10FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_10FPS(hook, hookCallback);
    public void Hook_Thread_10Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_10Minutes(hook, hookCallback);
    public void Hook_Thread_10Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_10Seconds(hook, hookCallback);
    public void Hook_Thread_15Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_15Minutes(hook, hookCallback);
    public void Hook_Thread_1Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_1Minutes(hook, hookCallback);
    public void Hook_Thread_1Second(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_1Second(hook, hookCallback);
    public void Hook_Thread_20FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_20FPS(hook, hookCallback);
    public void Hook_Thread_20Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_20Seconds(hook, hookCallback);
    public void Hook_Thread_2FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_2FPS(hook, hookCallback);
    public void Hook_Thread_30FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_30FPS(hook, hookCallback);
    public void Hook_Thread_30Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_30Seconds(hook, hookCallback);
    public void Hook_Thread_4FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_4FPS(hook, hookCallback);
    public void Hook_Thread_5FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_5FPS(hook, hookCallback);
    public void Hook_Thread_5Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_5Minutes(hook, hookCallback);
    public void Hook_Thread_5Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_5Seconds(hook, hookCallback);
    public void Hook_Thread_60FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_Thread_60FPS(hook, hookCallback);
    public void Hook_UnityThread_10FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_10FPS(hook, hookCallback);
    public void Hook_UnityThread_10Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_10Minutes(hook, hookCallback);
    public void Hook_UnityThread_10Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_10Seconds(hook, hookCallback);
    public void Hook_UnityThread_15Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_15Minutes(hook, hookCallback);
    public void Hook_UnityThread_1Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_1Minutes(hook, hookCallback);
    public void Hook_UnityThread_1Second(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_1Second(hook, hookCallback);
    public void Hook_UnityThread_20FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_20FPS(hook, hookCallback);
    public void Hook_UnityThread_20Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_20Seconds(hook, hookCallback);
    public void Hook_UnityThread_2FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_2FPS(hook, hookCallback);
    public void Hook_UnityThread_30FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_30FPS(hook, hookCallback);
    public void Hook_UnityThread_30Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_30Seconds(hook, hookCallback);
    public void Hook_UnityThread_4FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_4FPS(hook, hookCallback);
    public void Hook_UnityThread_5FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_5FPS(hook, hookCallback);
    public void Hook_UnityThread_5Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_5Minutes(hook, hookCallback);
    public void Hook_UnityThread_5Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_5Seconds(hook, hookCallback);
    public void Hook_UnityThread_60FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook() .Hook_UnityThread_60FPS(hook, hookCallback);

    public void Hook_Thread(TimeFrequenceType frequence, HookType hook, Action hookCallback)=>
        HookTimeFacadeOMI.GetInstanceHook().Hook_Thread(frequence, hook, hookCallback);
    public void Hook_UnityThread(TimeFrequenceType frequence, HookType hook, Action hookCallback)=>
        HookTimeFacadeOMI.GetInstanceHook().Hook_UnityThread(frequence, hook, hookCallback);
}
public class AccessTimerHookOmi : AbstractHookToTimeThreadCycleOMISide
{
    public bool IsStaticInstanceDefine() { return HookTimeFacadeOMI.GetInstanceHook()!=null; }
    public override void Hook_Thread_10FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()            .Hook_Thread_10FPS(       hook, hookCallback);
    public override void Hook_Thread_10Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_Thread_10Minutes(       hook, hookCallback);
    public override void Hook_Thread_10Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_Thread_10Seconds(       hook, hookCallback);
    public override void Hook_Thread_15Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_Thread_15Minutes(       hook, hookCallback);
    public override void Hook_Thread_1Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()         .Hook_Thread_1Minutes(       hook, hookCallback);
    public override void Hook_Thread_1Second(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()          .Hook_Thread_1Second(       hook, hookCallback);
    public override void Hook_Thread_20FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()            .Hook_Thread_20FPS(       hook, hookCallback);
    public override void Hook_Thread_20Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_Thread_20Seconds(       hook, hookCallback);
    public override void Hook_Thread_2FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()             .Hook_Thread_2FPS(        hook, hookCallback);
    public override void Hook_Thread_30FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()            .Hook_Thread_30FPS(       hook, hookCallback);
    public override void Hook_Thread_30Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_Thread_30Seconds(       hook, hookCallback);
    public override void Hook_Thread_4FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()             .Hook_Thread_4FPS(        hook, hookCallback);
    public override void Hook_Thread_5FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()             .Hook_Thread_5FPS(        hook, hookCallback);
    public override void Hook_Thread_5Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()         .Hook_Thread_5Minutes(       hook, hookCallback);
    public override void Hook_Thread_5Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()         .Hook_Thread_5Seconds(       hook, hookCallback);
    public override void Hook_Thread_60FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()            .Hook_Thread_60FPS(       hook, hookCallback);
    public override void Hook_UnityThread_10FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()       .Hook_UnityThread_10FPS(       hook, hookCallback);
    public override void Hook_UnityThread_10Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()   .Hook_UnityThread_10Minutes(       hook, hookCallback);
    public override void Hook_UnityThread_10Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()   .Hook_UnityThread_10Seconds(       hook, hookCallback);
    public override void Hook_UnityThread_15Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()   .Hook_UnityThread_15Minutes(       hook, hookCallback);
    public override void Hook_UnityThread_1Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()    .Hook_UnityThread_1Minutes(       hook, hookCallback);
    public override void Hook_UnityThread_1Second(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()     .Hook_UnityThread_1Second(       hook, hookCallback);
    public override void Hook_UnityThread_20FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()       .Hook_UnityThread_20FPS(       hook, hookCallback);
    public override void Hook_UnityThread_20Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()   .Hook_UnityThread_20Seconds(       hook, hookCallback);
    public override void Hook_UnityThread_2FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_UnityThread_2FPS(       hook, hookCallback);
    public override void Hook_UnityThread_30FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()       .Hook_UnityThread_30FPS(       hook, hookCallback);
    public override void Hook_UnityThread_30Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()   .Hook_UnityThread_30Seconds(       hook, hookCallback);
    public override void Hook_UnityThread_4FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_UnityThread_4FPS(       hook, hookCallback);
    public override void Hook_UnityThread_5FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()        .Hook_UnityThread_5FPS(       hook, hookCallback);
    public override void Hook_UnityThread_5Minutes(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()    .Hook_UnityThread_5Minutes(       hook, hookCallback);
    public override void Hook_UnityThread_5Seconds(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()    .Hook_UnityThread_5Seconds(       hook, hookCallback);
    public override void Hook_UnityThread_60FPS(HookType hook, Action hookCallback) => HookTimeFacadeOMI.GetInstanceHook()       .Hook_UnityThread_60FPS(       hook, hookCallback);

    
}

