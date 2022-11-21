using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Path
{
    [SerializeField] private GameObject[] _points;


    public void ShowPoints()
    {
        foreach (GameObject item in _points)
        {
            item.SetActive(true);
        }
    }

    public void HidePoints()
    {
        foreach (GameObject item in _points)
        {
            item.SetActive(false);
        }
    }
}
