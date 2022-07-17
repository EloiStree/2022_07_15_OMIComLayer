using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The aim here is to register command to be executed at date that are not close from now and that need to still existe if the application is closed.
/// OMI is not an application that I want to go in this direction but that would be stupid to not have this option.
/// 
/// </summary>
public interface I_PushCommandToCalendarTime 
{
    //As calendar should not be milliseconds aimed, (if you need just trigger a macro before the calendar date that will be precise)
    //I will only store in the calendar register commandline that you can convert anyway in shortcut group with the interpretor in OMI.
    // PS: This command don't autolauch the application. And so won't execute if OMI is not open before the given date.:
    // PS: You can remove a command in this version, just add and let's the user remove all or specific command by hand.
    // PS: You can't stack same commands at spécific time.

    [System.Serializable]
    public struct Executor_TimeOfDay {
       public byte m_hour_0_23;
       public byte m_minute_0_59;
       public byte m_second_0_59;
       public byte m_millisecond_0_999;
    }
    public enum DayOfTheWeek:byte { Monday ,Tuesday ,Wednesday ,Thursday ,Friday, Saturday ,Sunday }

    public void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine);
    public void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in Executor_TimeOfDay date, in string commandLine);
    public void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in DayOfTheWeek dayOfTheWeak , in Executor_TimeOfDay date, in string commandLine);
    public void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in Executor_TimeOfDay date, in string commandLine);
    public void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine);
}
