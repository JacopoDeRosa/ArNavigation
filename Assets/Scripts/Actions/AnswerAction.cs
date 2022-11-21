using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnswerAction : MonoBehaviour
{
  
    [SerializeField]
    Domanda _domanda;

    public UnityEvent OnAnswer;
    // Start is called before the first frame update
    public void OnRisposta(Domanda domanda)
    {
        if(domanda==_domanda)
        {
            OnAnswer.Invoke();
        }



    }

    private void Start()
    {
        FindObjectOfType<DomandaUI>().onRisposta.AddListener(OnRisposta);
    }

    // Update is called once per frame

}
