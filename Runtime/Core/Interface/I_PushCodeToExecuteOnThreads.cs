using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClassicThreadTarget { SideThread, UnityThread, DoAndDieParallelThread }
public enum DualThreadTarget { SideThread, UnityThread, }
public interface  I_PushCodeToExecuteOnThreads 
{
    /// <summary>
    /// OMI has a main thread where to execute code that don't need Unity to have more responsive and not frame rate linked code
    /// Consider that UnityThread is slow to 1-5 frame when user don't focus the Unity App to wake in "sleep" mode"
    /// DoAndDie is when you need the code to execute on parallel thread that will be kill as soon as the tasks is done. Avoid if you can but use if you need.
    /// </summary>
    public delegate void ActionCall();
    /// <summary>
    /// Will try to execute without filter.
    /// </summary>
    /// <param name="toDo"></param>
    public void ExecuteAlmostDirectly(in ClassicThreadTarget thread, in ActionCall toDo);
    /// <summary>
    /// Will wait to be executed in hight priority but can wait to avoid software to freeze.
    /// </summary>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteASAP(in ClassicThreadTarget thread, in ActionCall toDo);
    /// <summary>
    /// Will wait to be executed as soon as possible but if an other thread want priority we gently let's them first
    /// </summary>
    /// <param name="oneIfHurryZeroIsCanWait"></param>
    /// <param name="timeInSeconds"></param>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteGentlemanASAP(in float oneIfHurryZeroIsCanWait ,in double timeInSeconds, in ClassicThreadTarget thread, in ActionCall toDo);

    /// <summary>
    /// In Omi a Thread is running only for AtExactly and InExactly in aim to execute code that can't wait and must be executed a precise timing.
    /// PS: if there are 4 methodes asking at the same time or one methode before yours is taking 10 ms it won't help you so use this methode only if you need precise timing and try to make it short.
    /// </summary>
    /// <param name="time"></param>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteAtExactly(in DateTime time, in ClassicThreadTarget thread, in ActionCall toDo);

    /// <summary>
    /// In Omi a Thread is running only for AtExactly and InExactly in aim to execute code that can't wait and must be executed a precise timing.
    /// PS: if there are 4 methodes asking at the same time or one methode before yours is taking 10 ms it won't help you so use this methode only if you need precise timing and try to make it short.
    /// </summary>
    /// <param name="time"></param>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteInExactly(in double timeInSeconds, in ClassicThreadTarget thread, in ActionCall toDo);
    /// <summary>
    /// Will add the methode to be call at precise timing but as a asap methode not on seperate thread.
    /// </summary>
    /// <param name="time"></param>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteAt(in DateTime time, in ClassicThreadTarget thread, in ActionCall toDo);

    /// <summary>
    /// Will add the methode to be call in the target about of time run on as a asap methode
    /// </summary>
    /// <param name="time"></param>
    /// <param name="thread"></param>
    /// <param name="toDo"></param>
    public void ExecuteIn(in double timeInSeconds, in ClassicThreadTarget thread, in ActionCall toDo);


}
