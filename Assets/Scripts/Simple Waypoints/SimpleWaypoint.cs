using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleWaypoint : MonoBehaviour
{
    [SerializeField] private GameObject _nextPoint;

    public UnityEvent onNextPoint;

    private void OnTriggerEnter(Collider other)
    {
        SetNextPoint();
    }

    public void SetNextPoint()
    {
        if(_nextPoint != null) _nextPoint.SetActive(true);
        gameObject.SetActive(false);
        onNextPoint.Invoke();
    }
}
