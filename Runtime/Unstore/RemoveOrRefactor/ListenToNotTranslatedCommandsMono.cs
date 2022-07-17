using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenToNotTranslatedCommands
{
    #region LISTEN TO OMI
    static Action<string> m_listenToCommandLineNotTranslated;
    static Action<string> m_listenToShortcutNotTranslated;
    static Action<string> m_listenToShortcutGroupNotTranslated;


    public static void PushCommandNotTranslated(in string messsage)
    {
        if (m_listenToCommandLineNotTranslated != null)
            m_listenToCommandLineNotTranslated.Invoke(messsage);
    }
    public static void PushShortcutNotTranslated(in string messsage)
    {
        if (m_listenToShortcutNotTranslated != null)
            m_listenToShortcutNotTranslated.Invoke(messsage);
    }
    public static void PushShortcutGroupNotTranslated(in string messsage)
    {
        if (m_listenToShortcutGroupNotTranslated != null)
            m_listenToShortcutGroupNotTranslated.Invoke(messsage);
    }

    public void ListenToCommandLineNotTranslated(bool addTrueRemoveFalse, Action<string> commandLine)
    {
        AddToListener(addTrueRemoveFalse, m_listenToCommandLineNotTranslated, commandLine);
    }

    public void ListenToShortcutNotTranslated(bool addTrueRemoveFalse, Action<string> shortcut)
    {
        AddToListener(addTrueRemoveFalse, m_listenToShortcutNotTranslated, shortcut);
    }
    public void ListenToShortcutGroupNotTranslated(bool addTrueRemoveFalse, Action<string> shortcut)
    {
        AddToListener(addTrueRemoveFalse, m_listenToShortcutGroupNotTranslated, shortcut);
    }

    public void AddToListener(bool addTrue, Action<string> target, Action<string> action)
    {
        if (addTrue)
            target += action.Invoke;
        else
            target -= action.Invoke;
    }
    public void AddToListener(bool addTrue, Action target, Action action)
    {
        if (addTrue)
            target += action.Invoke;
        else
            target -= action.Invoke;
    }


    #endregion
}


