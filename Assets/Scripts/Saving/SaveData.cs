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
        File.WriteAllText(DocumentsPath + "/DatiSessione" + SessionData.UserName + ".json", json);
    }
}

public class Mat
{
    public string Name { get; set; }

    public Mat(string name)
    {
        Name = name;
    }
}
    

