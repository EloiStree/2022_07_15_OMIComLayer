using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuickHookOnChannelDemoMono : MonoBehaviour
{
    public TimeFrequenceType m_frequence;
    public bool m_hookToThread=false;
    public UnityEvent m_threadEvent;
    public bool m_hookToUnityThread=true;
    public UnityEvent m_unityEvent;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        if (m_hookToThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_Thread(m_frequence, HookType.Hook, m_threadEvent.Invoke);
        if(m_hookToUnityThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_UnityThread(m_frequence, HookType.Hook, m_unityEvent.Invoke);
    }

    void OnDestroy()
    {

        if (m_hookToThread)
        HookTimeFacadeOMI.GetInstanceHook().Hook_Thread(m_frequence, HookType.Unhook, m_threadEvent.Invoke);
            if (m_hookToUnityThread)
                HookTimeFacadeOMI.GetInstanceHook().Hook_UnityThread(m_frequence, HookType.Unhook, m_unityEvent.Invoke);
    }
    public void LogA() { Debug.Log("AAA"); }
    public void LogB() { Debug.Log("BBB"); }
    public void LogC() { Debug.Log("CCC"); }
}
