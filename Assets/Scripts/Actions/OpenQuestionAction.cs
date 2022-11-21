using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenQuestionAction : MonoBehaviour
{
    [SerializeField] private Domanda _domanda;

    private void Start()
    {
        FindObjectOfType<DomandaUI>().ReadQuestion(_domanda);
    }
}
