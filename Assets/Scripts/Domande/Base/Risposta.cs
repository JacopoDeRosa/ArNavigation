using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Risposta
{
    [SerializeField] private string _testo;

    public string Testo { get => _testo; }
}
