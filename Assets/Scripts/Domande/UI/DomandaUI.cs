using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DomandaUI : MonoBehaviour
{
    [SerializeField] Transform _background, _containerDomanda, _containerRisposte;
    [SerializeField] private BottoneRisposta[] _bottoni;
    [SerializeField] private TMP_Text _testoDomanda, _titoloDomanda;


    private Domanda _domandaAttiva;

    public UnityEvent<Domanda> onRisposta;

    public System.Action onRispostaSbagliata;

    public void ReadQuestion(Domanda domanda)
    {
      StartCoroutine(ReadQuestionRoutine(domanda));
    }

    public void ReadQuestionDelayed(Domanda domanda)
    {
        StartCoroutine(ReadQuestionDelayedRoutine(domanda));
    }

    public bool TryAnswer(int answer)
    {
        bool correct = answer == _domandaAttiva.RispostaCorretta;
        if(correct)
        {
            onRisposta.Invoke(_domandaAttiva);
            StartCoroutine(ResetUI());
        }
        else
        {
            onRispostaSbagliata?.Invoke();
        }    
        
        return correct; 
    }

    private IEnumerator ReadQuestionRoutine(Domanda domanda)
    {
        WaitForSeconds wait = new WaitForSeconds(0.02f);

        _background.gameObject.SetActive(true);
        _containerDomanda.gameObject.SetActive(true);
        _containerRisposte.gameObject.SetActive(true);

        _domandaAttiva = domanda;

        _testoDomanda.text = domanda.TestoDomanda;
        _titoloDomanda.text = domanda.Titolo;

        foreach (var bottone in _bottoni)
        {
            bottone.gameObject.SetActive(false);
        }

        for (int i = 0; i < domanda.Risposte.Length; i++)
        {
            _bottoni[i].gameObject.SetActive(true);
            _bottoni[i].SetAnswer(domanda.Risposte[i], i);
        }

        Vector3 scale = new Vector3(0, 0, 0);

        while(scale.x < 1)
        {
            scale.Set(scale.x + (1 * 0.02f), scale.y + (1 * 0.02f), scale.y + (1 * 0.02f));
            _background.localScale = scale;
            _containerDomanda.localScale = scale;
            _containerRisposte.localScale = scale;
            yield return wait;
        }

        _containerDomanda.localScale = Vector3.one;
        _containerRisposte.localScale = Vector3.one;
    }

    private IEnumerator ReadQuestionDelayedRoutine(Domanda domanda)
    {
        yield return new WaitForSeconds(2.00f);
        yield return ReadQuestionRoutine(domanda);

    }

    private IEnumerator ResetUI()
    {
        WaitForSeconds wait = new WaitForSeconds(0.02f);

        Vector3 scale = new Vector3(1, 1, 1);

        while (scale.x > 0)
        {
            scale.Set(scale.x - (1 * 0.02f), scale.y - (1 * 0.02f), scale.y - (1 * 0.02f));
            _background.localScale = scale;
            _containerDomanda.localScale = scale;
            _containerRisposte.localScale = scale;
            yield return wait;
        }
        _background.gameObject.SetActive(false);
        _containerDomanda.gameObject.SetActive(false);
        _containerRisposte.gameObject.SetActive(false);
    }
}
