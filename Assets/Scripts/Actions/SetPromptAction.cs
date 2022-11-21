using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPromptAction : MonoBehaviour
{
    [SerializeField] private string _prompt;

    void Start()
    {
        FindObjectOfType<UiManager>().SetPromptText(_prompt);
    }

}
