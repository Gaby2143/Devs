using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Find_file 
{
    public static bool Exist(string name)
    {
        if (System.IO.File.Exists(Get_resources_folder()+"/"+name)) return true;
        else return false;
    }

    private static string Get_resources_folder()
    {
        return Application.dataPath + "/Resources/"; 
    }
}
