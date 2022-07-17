using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTaskOnOMICalenderMono : MonoBehaviour, I_PushCommandToCalendarTime
{
    public void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarAtDate(in thread, in date, in commandLine);
    }
    public void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarEveryDayAt(in thread, in date, in commandLine);
    }
    public void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryMonthAtIndex(in thread, in index_0_31, in startToEndOfMonth, in date, in commandLine);
    }
    public void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryWeekAt(in thread, in dayOfTheWeak, in date, in commandLine);
    }

    public void PutCalendarPusherAsActive(in bool isActive)
    {
        StaticCalendarExecutorComBridge.GetInstance().PutCalendarPusherAsActive(isActive);
    }

    public void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            RepeatExecutionEvery(in thread, in date, in millisecondsBetweenRepeat, in commandLine);
    }
}
public class StaticCalendarExecutorComBridge
{
    public static I_PushCommandToCalendarTime m_executorBridge = new DoNothingAccessClendarExecutor();
    public static I_PushCommandToCalendarTime GetInstance() { return m_executorBridge; }
    public static void SetTimeExecuter(I_PushCommandToCalendarTime executor) { m_executorBridge = executor; }
    public static void RemoveTimeExecuter()
    {
        m_executorBridge = new DoNothingAccessClendarExecutor();
    }
}
public abstract class AbstractAccessClendarExecutor : I_PushCommandToCalendarTime
{
    public abstract void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine);
    public abstract void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine);
    public abstract void PutCalendarPusherAsActive(in bool isActive);
    public abstract void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine);
}

public class DoNothingAccessClendarExecutor : AbstractAccessClendarExecutor
{
    public override void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine){}
    public override void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}
    public override void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}
    public override void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)    {}

    public override void PutCalendarPusherAsActive(in bool isActive) { }
    public override void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)    {}
}
public class AccessCalendarExecutorPushToOmiFromStatic : AbstractAccessClendarExecutor
{
    public override void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarAtDate(in thread, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            ExecuteCalendarEveryDayAt(in thread, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryMonthAtIndex(in thread, in index_0_31, in startToEndOfMonth, in date, in commandLine);
    }

    public override void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
             ExecuteCalendarEveryWeekAt(in thread, in dayOfTheWeak, in date, in commandLine);
    }

    public override void PutCalendarPusherAsActive(in bool isActive)
    {
        StaticCalendarExecutorComBridge.GetInstance().
             PutCalendarPusherAsActive(in isActive);
    }

    public override void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)
    {
        StaticCalendarExecutorComBridge.GetInstance().
            RepeatExecutionEvery(in thread, in date, in millisecondsBetweenRepeat, in commandLine);
    }
}