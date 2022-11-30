using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenQuestionDelay : MonoBehaviour
{
    [SerializeField] private Domanda _domanda;
    [SerializeField] private float _delay;

    private void Start()
    {
        FindObjectOfType<DomandaUI>().ReadQuestionDelayed(_domanda, _delay);
    }
}
