using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScoreContainer
{
    [SerializeField] private Domanda _domanda;
    [SerializeField] private bool _corretta;

    public Domanda Domanda { get => _domanda; }
    public bool Corretta { get => _corretta; }

    public ScoreContainer(Domanda domanda, bool corretta)
    {
        _domanda = domanda;
        _corretta = corretta;
    }
}
