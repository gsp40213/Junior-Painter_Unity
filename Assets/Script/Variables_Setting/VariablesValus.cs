using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesValus
{
    // file button actvie
    private static bool _FILE_ACTIVE_SW = false;
    public static bool FILE_ACTIVE_SW_SET { set { _FILE_ACTIVE_SW = value; } }
    public static bool FILE_ACTIVE_SW_GET { get { return _FILE_ACTIVE_SW; } }

    // startusBar active
    private static int _STARTUSBAR_SW = 0;
    public static int STARTUSBAR_SW_SET { set { _STARTUSBAR_SW = value; } }
    public static int STARTUSBAR_SW_GET { get { return _STARTUSBAR_SW; } }

}
