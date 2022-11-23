using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveData
{
   private static string DocumentsPath { get => System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); }


    public static void SaveSessionData()
    {
        string json = JsonUtility.ToJson(SessionData.GetSessionDataContainer());
        File.Create(DocumentsPath + "/DatiSessione" + SessionData.UserName + ".json");
        File.WriteAllText(DocumentsPath + "/DatiSessione" + SessionData.UserName + ".json", json);
    }
}

    

