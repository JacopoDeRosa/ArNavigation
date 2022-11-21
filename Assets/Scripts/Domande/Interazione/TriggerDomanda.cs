using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDomanda : MonoBehaviour
{
    [SerializeField] private Domanda _domanda;
    [SerializeField] private bool _dieOnUse;

    public Domanda Domanda { get => _domanda; }

    private DomandaUI _ui;

    private void Start()
    {
        _ui = FindObjectOfType<DomandaUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");

        _ui.ReadQuestion(_domanda);

        if (_dieOnUse) Destroy(gameObject);
    }
}
