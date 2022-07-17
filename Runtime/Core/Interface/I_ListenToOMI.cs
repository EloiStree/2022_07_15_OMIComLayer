using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface I_ListenToOMI 
{

    public void ListenToFileExtensionChange(
        bool addTrueRemoveFalse, Action<string> fileExtensionChanged);

    public void ListenToConfigFileChange(bool addTrueRemoveFalse, Action fileExtensionChanged);
    public void ListenToConfigXmlChange(bool addTrueRemoveFalse, Action fileExtensionChanged);

    public void ListenToCommandLineNotTranslated(
        bool addTrueRemoveFalse, Action<string> commandLine);

    public void ListenToShortcutNotTranslated(
        bool addTrueRemoveFalse, Action<string> shortcut);



}
