using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<DomandaUI>().onRispostaSbagliata += OnWrongAnswer;
    }

    public void OnWrongAnswer()
    {
        SessionData.IncreaseWrongQuestions();
    }
}
