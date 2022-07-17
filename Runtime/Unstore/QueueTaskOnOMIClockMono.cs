using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTaskOnOMIClockMono : MonoBehaviour, I_PushCodeToExecuteOnThreads
{
    public void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAlmostDirectly(in thread, in toDo);
    }
    public void ExecuteASAP(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteASAP(in thread, in toDo);
    }
    public void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAt(in time, in thread, in toDo);
    }
    public void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAtExactly(in time, in thread, in toDo);
    }
    public void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait, in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteGentlemanASAP(in oneIfHurryZeroIsCanWait, in timeInSeconds, in thread, in  toDo);
    }
    public void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteIn(in timeInSeconds, in thread, in toDo);
    }
    public void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteInExactly(in timeInSeconds, in thread, in toDo);
    }
}

public class StaticTimeExecuterComBridge {
    public static I_PushCodeToExecuteOnThreads m_executorBridge = new DoNothingAccessTimeExecutor();
    public static I_PushCodeToExecuteOnThreads GetInstance() { return m_executorBridge;}
    public static void SetTimeExecuter(I_PushCodeToExecuteOnThreads executor) { m_executorBridge = executor; }
    public static void RemoveTimeExecuter()
    {
        m_executorBridge = new DoNothingAccessTimeExecutor();
    }
}
public abstract class AbstractAccessTimeExecutor : I_PushCodeToExecuteOnThreads
{
    public abstract void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteASAP(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait, in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
    public abstract void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo);
}

public class DoNothingAccessTimeExecutor : AbstractAccessTimeExecutor
{
    public override void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteASAP(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait, in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
    public override void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo) { }
}
public class AccessTimeExecutorPushToOmiFromStatic : AbstractAccessTimeExecutor
{
    public override void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAlmostDirectly(in thread, in toDo);
    }

    public override void ExecuteASAP(in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteASAP(in thread, in toDo);
    }

    public override void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAt(in time, in thread, in toDo);
    }

    public override void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteAtExactly(in time, in thread, in toDo);
    }

    public override void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait, in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteGentlemanASAP(in oneIfHurryZeroIsCanWait, in timeInSeconds, in thread, in toDo);
    }

    public override void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteIn(in timeInSeconds, in thread, in toDo);
    }

    public override void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in I_PushCodeToExecuteOnThreads.ActionCall toDo)
    {
        StaticTimeExecuterComBridge.GetInstance().ExecuteInExactly(in timeInSeconds, in thread, in toDo);
    }
}