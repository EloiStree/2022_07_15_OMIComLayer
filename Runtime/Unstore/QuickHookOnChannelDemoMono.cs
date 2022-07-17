using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuickHookOnChannelDemoMono : MonoBehaviour
{
    public bool m_isHookActive;
    public TimeFrequenceType m_frequence;
    public bool m_hookToThread=false;
    public Action m_threadEventListener;
     bool m_pushUnityEventOnUpdate;
    public UnityEvent m_threadEventOnUpdate;
    public bool m_hookToUnityThread=true;
    public UnityEvent m_unityEvent;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        if (m_hookToThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_Thread(m_frequence, HookType.Hook, PushThread);
        if(m_hookToUnityThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_UnityThread(m_frequence, HookType.Hook, PushUnity);
    }
    public void PushUnity()
    {
        if (m_isHookActive)
            m_unityEvent.Invoke();
    }
    public void PushThread() {
        if (m_isHookActive)
        {
            m_pushUnityEventOnUpdate = true;
            inc++;
            m_threadEventOnUpdate.Invoke();
            LogC();
        }
    }
    public int inc=0;
    private void Update()
    {
        if (m_pushUnityEventOnUpdate) {
            m_pushUnityEventOnUpdate = false;
            m_threadEventOnUpdate.Invoke();
        }

    }

    void OnDestroy()
    {

        if (m_hookToThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_Thread(m_frequence, HookType.Unhook, m_threadEventOnUpdate.Invoke);
        if (m_hookToUnityThread)
            HookTimeFacadeOMI.GetInstanceHook().Hook_UnityThread(m_frequence, HookType.Unhook, m_unityEvent.Invoke);
    }
    public void LogA() { Debug.Log("AAA"); }
    public void LogB() { Debug.Log("BBB"); }
    public void LogC() { Debug.Log("CCC"); }
}
