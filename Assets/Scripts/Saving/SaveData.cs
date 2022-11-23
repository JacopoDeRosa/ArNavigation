using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveData
{
   private static string DocumentsPath { get => System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); }


    public static void SaveSessionData()
    {
        string json = JsonUtility.ToJson(SessionData.GetSessionDataContainer());

    }

}

