using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public static class SaveData
{
   private static string DocumentsPath { get => System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); }
   private static string Path { get => DocumentsPath + "/DatiSessione" + SessionData.UserName + ".json"; }

    public static void SaveSessionData()
    {
        string json = JsonUtility.ToJson(SessionData.GetSessionDataContainer());
        
        using(StreamWriter sw = File.CreateText(Path))
        {
            sw.Write(json);
        }
    }
}

    

