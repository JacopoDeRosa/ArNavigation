using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MultiCheckTest : MonoBehaviour
{
    [SerializeField] private MultiCheckButton[] _buttons;

    public UnityEvent onTestEnd;

    public void BeginTest()
    {
        foreach (MultiCheckButton button in _buttons)
        {
            button.Init();
            button.onPress += OnButtonPressed;
        }
    }

    private void EndTest()
    {

    }

    private void OnButtonPressed()
    {
        
    }
}
