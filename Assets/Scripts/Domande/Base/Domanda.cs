using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuova Domanda", menuName = "Nuova Domanda")]
public class Domanda : ScriptableObject
{
    [SerializeField] 
    private string _titolo;

    [SerializeField][TextArea(0,50)]
    private string _testoDomanda;

    [SerializeField]
    private int _rispostaCorretta;

    [SerializeField]
    private Risposta[] _possibiliRisposte;
    

    public string Titolo { get => _titolo; }
    public string TestoDomanda { get => _testoDomanda; }
    public int RispostaCorretta { get => _rispostaCorretta; }
    public Risposta[] Risposte { get => _possibiliRisposte; }

    private void OnValidate()
    {
      _testoDomanda = _testoDomanda.Replace("\r", "");
    }
}
