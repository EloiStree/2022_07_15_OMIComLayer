using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyScript_PullPushInfoComOMI : MonoBehaviour
{
    public BasicOmiModuleSideMono m_com;
    public string m_booleanName="Name001";
    public bool m_booleanValue;
    public bool m_isDefined;

    public string m_commandLine="cmd";
    public string m_shortcutLine="shortcut";
    public string m_shortcutLineGroup="shortcutgroup";

    [ContextMenu("Push CommandLine")]
    public void PushCommandLine()
    {
        m_com.PushCommandLine(in m_commandLine);
    }
    [ContextMenu("Push Shortcut")]
    public void PushShortcut()
    {
        m_com.PushShortcut(in m_shortcutLine, false);
    }
    [ContextMenu("Push Shortcut Group")]
    public void PushShortcutGroup()
    {
        m_com.PushShortcut(in m_shortcutLineGroup, true);
    }


    [ContextMenu("SetBoolean")]
    public void SetBoolean()
    {
        m_com.SetBooleanValue(in m_booleanName, in m_booleanValue);
    }
    [ContextMenu("GetBoolean")]
    public void GetBoolean()
    {
        m_isDefined = m_com.IsBooleanExists(in m_booleanName);
        if (m_isDefined)
        { 
            m_booleanValue = m_com.GetBooleanValue(in m_booleanName, false);  
        }
    }
  
}
