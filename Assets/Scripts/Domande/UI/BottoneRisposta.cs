using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BottoneRisposta : MonoBehaviour
{
    [SerializeField] private TMP_Text _testo;
    [SerializeField] private DomandaUI _parent;
    [SerializeField] private Button _button;
    [SerializeField] private Image _background;

    private int _index;

    Color _defaultColor;

    private void OnValidate()
    {
        _parent = FindObjectOfType<DomandaUI>();
    }

    private void Awake()
    {
        _button.onClick.AddListener(TryAnswer);
        _defaultColor = _background.color;
    }

    private void TryAnswer()
    {
        Color color = _parent.TryAnswer(_index) ? Color.green : Color.red;
        _background.color = color;
    }

    public void SetAnswer(Risposta risposta, int index)
    {
        _testo.text = risposta.Testo;
        _index = index;
        _background.color = _defaultColor;
    }

}
