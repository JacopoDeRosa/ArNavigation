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
            button.gameObject.SetActive(true);
            button.Init();
            button.onPress += OnButtonPressed;
        }
    }

    private void EndTest()
    {
        onTestEnd?.Invoke();
        foreach (MultiCheckButton button in _buttons)
        {
            button.gameObject.SetActive(false);
        }
    }

    private void OnButtonPressed()
    {
       
        foreach (MultiCheckButton button in _buttons)
        {
            if (button.Pressed == false) return;
        }

        EndTest();
    }
}
