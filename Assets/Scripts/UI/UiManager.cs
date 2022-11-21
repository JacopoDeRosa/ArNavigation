using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _promptText;

    public void SetPromptText(string text)
    {
        _promptText.text = text;
    }

    public void ResetPromptText()
    {
        _promptText.text = "";
    }

}
