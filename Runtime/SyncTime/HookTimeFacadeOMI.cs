using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookTimeFacadeOMI
{
    static HookTimeFacadeOMI()
    {
        m_instance = new HookAndNotifyToTimeThreadCycleOMI();
        m_instanceHook = m_instance;
        m_instanceNotify = m_instance;
    }
    static HookAndNotifyToTimeThreadCycleOMI m_instance;
    static I_HookToTimeThreadCycleOMI m_instanceHook;
    static I_NotifyToHookToTimeThreadCycleOMI m_instanceNotify;
    public static I_HookToTimeThreadCycleOMI GetInstanceHook() { return m_instanceHook; }
    public static I_NotifyToHookToTimeThreadCycleOMI GetInstanceHookNotify() { return m_instanceNotify; }

}
