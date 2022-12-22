using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class BottoneAmicone : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    string toShow;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShowAll();
        }
    }
    public void ShowAll()
    {
        Debug.Log("Showing All");
        foreach (string file in Directory.EnumerateFiles(Application.persistentDataPath, "*.json"))
        {
           toShow += File.ReadAllText(file) + "\n";
        }

        _text.text = toShow;

    }
}
