using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeComLayerOMI 
{
    public static AbstractBasicBoolCmdOmiSide m_omiSide =  new Mock_BasicBoolCmdOmiSide();
    public static AbstractBasicBoolCmdOmiSide GetOmiSide() { return m_omiSide; }

  
}
