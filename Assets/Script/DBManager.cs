using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static int coin;
    public static int level;
    public static string username;
    public static bool LoggedIn {get {return username!=null;}}

    public static void LoggedOut()
    {
        username = null;
    }
}
