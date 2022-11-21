using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDomande : MonoBehaviour
{
    [SerializeField]
    private List<ScoreContainer> _scoreContainers;

    public List<ScoreContainer> ScoreContainers { get => _scoreContainers; }

    private void Awake()
    {
        _scoreContainers = new List<ScoreContainer>();
    }

    public void OnAnswer(Domanda domanda, bool correct)
    {
        _scoreContainers.Add(new ScoreContainer(domanda, correct));
    }
}
