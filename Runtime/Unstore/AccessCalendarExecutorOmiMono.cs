using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessCalendarExecutorOmiMono :MonoBehaviour, I_PushCommandToCalendarTime
{
    public void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarAtDate(in thread, in date, in commandLine);
    }
    public void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarEveryDayAt(in thread, in date, in commandLine);
    }
    public void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryMonthAtIndex(in thread, in index_0_31, in startToEndOfMonth, in date, in commandLine);
    }
    public void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryWeekAt(in thread, in dayOfTheWeak, in date, in commandLine);
    }
    public void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            RepeatExecutionEvery(in thread, in date, in millisecondsBetweenRepeat, in commandLine);
    }
}
public class AccessCalendarExecutorComBridge
{
    public static I_PushCommandToCalendarTime m_executorBridge = new DoNothingAccessClendarExecutor();
    public static I_PushCommandToCalendarTime GetInstance() { return m_executorBridge; }
    public static void SetTimeExecuter(I_PushCommandToCalendarTime executor) { m_executorBridge = executor; }
    public static void RemoveTimeExecuter()
    {
        m_executorBridge = new DoNothingAccessClendarExecutor();
    }
}
public abstract class AccessClendarExecutor : I_PushCommandToCalendarTime
{
    public abstract void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine);
    public abstract void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine);
}

public class DoNothingAccessClendarExecutor : AccessClendarExecutor
{
    public override void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine){}
    public override void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}
    public override void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}
    public override void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}
    public override void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)    {}
}
public class AccessCalendarExecutorPushToOmiFromStatic : AccessClendarExecutor
{
    public override void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarAtDate(in thread, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarEveryDayAt(in thread, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryMonthAtIndex(in thread, in index_0_31, in startToEndOfMonth, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryWeekAt(in thread, in dayOfTheWeak, in date, in commandLine);
    }

    public override void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)
    {
        AccessCalendarExecutorComBridge.GetInstance().
            RepeatExecutionEvery(in thread, in date, in millisecondsBetweenRepeat, in commandLine);
    }
}