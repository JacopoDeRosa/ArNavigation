using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _wrongAnswers = 0;

    public int WrongAnswers { get => _wrongAnswers; }

    private void Awake()
    {
        FindObjectOfType<DomandaUI>().onRispostaSbagliata += OnWrongAnswer;
    }

    public void OnWrongAnswer()
    {
        _wrongAnswers++;
    }
}
