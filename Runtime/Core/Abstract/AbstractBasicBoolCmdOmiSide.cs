using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public abstract class AbstractBasicBoolCmdOmiSide : I_PushCommandToOMI, I_FetchSetBooleanOMI
{
   
    #region FETCH OMI
    public abstract bool IsBooleanExists(in string name);
    public abstract void GetBooleanValue(in string name, out bool value, in bool defaultIfNotDefined);
    public abstract bool GetBooleanValue(in string name, in bool defaultIfNotDefined);
    #endregion




    #region PUSH TO OMI
    [System.Serializable]
    public class StringLineEvent : UnityEvent<string> { }
    public StringLineEvent m_toInterpretCommandLine = new StringLineEvent();
    public StringLineEvent m_toInterpretShortcut = new StringLineEvent();
    public StringLineEvent m_toInterpretGroupSenstiveShortcut = new StringLineEvent();
    [System.Serializable]
    public class NamedBooleanEvent : UnityEvent<string, bool> { }
    public NamedBooleanEvent m_setBooleanTo = new NamedBooleanEvent();

    public void PushCommandLine(in string line)
    {
        m_toInterpretCommandLine.Invoke(line);
    }

    public void PushShortcut(in string line, in bool groupSensitive)
    {
        if (groupSensitive)
            m_toInterpretGroupSenstiveShortcut.Invoke(line);
        else
            m_toInterpretShortcut.Invoke(line);
    }

    public void SetBooleanValue(in string name, in bool value)
    {
        m_setBooleanTo.Invoke(name, value);
    }

    #endregion
}
