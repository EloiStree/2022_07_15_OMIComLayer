using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractImplementOmiModuleSideMono :MonoBehaviour,  I_PushCommandToOMI , I_FetchSetBooleanOMI //, I_ListenToOMI
{
    public void GetBooleanValue(in string name, out bool value, in bool defaultIfNotDefined)
    {
        FacadeComLayerOMI.GetOmiSide().GetBooleanValue(in name, out value, in defaultIfNotDefined);
    }

    public bool GetBooleanValue(in string name, in bool defaultIfNotDefined)
    {
        return FacadeComLayerOMI.GetOmiSide().GetBooleanValue(in name, in defaultIfNotDefined);
    }

    public void GetConfigFilesFromExtension(in string fileExtensionName, out string[] filesPath)
    {
        FacadeComLayerOMI.GetOmiSide().GetConfigFilesFromExtension(in fileExtensionName, out filesPath);
    }

    public void GetXmlItemFromTagName(in string xmlTag, out string xmlText)
    {
        FacadeComLayerOMI.GetOmiSide().GetXmlItemFromTagName(in xmlTag, out xmlText);
    }

    public bool IsBooleanExists(in string name)
    {
        return FacadeComLayerOMI.GetOmiSide().IsBooleanExists(in name);
    }

    public void PushCommandLine(in string line)
    {
        FacadeComLayerOMI.GetOmiSide().PushCommandLine(in line);
    }

    public void PushShortcut(in string line, in bool groupSensitive)
    {
        FacadeComLayerOMI.GetOmiSide().PushShortcut(in line, in groupSensitive);
    }

    public void SetBooleanValue(in string name, in bool newValue)
    {
        FacadeComLayerOMI.GetOmiSide().SetBooleanValue(in name,in newValue);
    }
}