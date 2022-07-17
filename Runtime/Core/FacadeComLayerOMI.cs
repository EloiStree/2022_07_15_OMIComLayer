using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeComLayerOMI 
{
    public static AbstractImplementOmiSide m_omiSide =  new Mock_AbstractImplementOmiSide();
    //public static AbstractImplementOmiModuleSideMono m_moduleSide;

    public static AbstractImplementOmiSide GetOmiSide() { return m_omiSide; }
    //public static AbstractImplementOmiModuleSideMono GetModuleSide() { return m_moduleSide; }

    public static void PushCommandLine(in string line)
    {
        m_omiSide.PushCommandLine(line);
    }

    public static void PushShortcut(in string line, bool groupSensitive)
    {
        m_omiSide.PushShortcut(in line, groupSensitive);
    }

    public static void SetBooleanValue(in string name, bool newValue)
    {
        m_omiSide.SetBooleanValue(in name, newValue);
    }
    
}
