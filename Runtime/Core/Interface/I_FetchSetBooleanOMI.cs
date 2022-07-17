using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface I_FetchSetBooleanOMI 
{
    /// <summary>
    /// Get boolean value of the given name (case ignore) 
    /// </summary>
    /// <param name="name">Boolean id name (case ignore)</param>
    /// <param name="value">Boolean value</param>
    /// <param defaultIfNotDefined="value">Boolean value if not defined</param>
    public void GetBooleanValue(in string name, out bool value, in bool defaultIfNotDefined);
    /// <summary>
    /// Get boolean value of the given name (case ignore) 
    /// </summary>
    /// <param name="name">Boolean id name (case ignore)</param>
    /// <param name="value">Boolean value</param>
    /// <param defaultIfNotDefined="value">Boolean value if not defined</param>
    public bool GetBooleanValue(in string name, in bool defaultIfNotDefined);

    /// <summary>
    /// Check if boolean exists 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public bool IsBooleanExists(in string name);

    /// <summary>
    /// All the application is based on boolean value that are named. Read the tutorial or documenation if you did not have yet.
    /// https://github.com/EloiStree/OpenMacroInputDocumentation
    /// </summary>
    /// <param name="name">Name of the boolean value not case sensitive</param>
    /// <param name="newValue">the new value you want. If the same as previous one it will be ignore</param>
    public void SetBooleanValue(in string name, in bool newValue);


    ///// <summary>
    ///// Get all files that are use in the config folder(s) based on the extension
    ///// </summary>
    ///// <param name="fileExtensionName">File extension</param>
    ///// <param name="filesPath">Computer path of the files with given extension name</param>
    //public void GetConfigFilesFromExtension(in string fileExtensionName, out string[] filesPath);
    ///// <summary>
    ///// Read the documentation. OMI use two type of import file and xml file. 
    ///// Not code yet.
    ///// </summary>
    ///// <param name="xmlTag"></param>
    ///// <param name="xmlText"></param>
    //public void GetXmlItemFromTagName(in string xmlTag, out string xmlText);
}
