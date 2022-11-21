using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSwitch : MonoBehaviour
{
    [SerializeField] private GameObject _a, _b;


    public void Switch()
    {
        _a.SetActive(!_a.activeInHierarchy);
        _b.SetActive(!_b.activeInHierarchy);
    }
}
