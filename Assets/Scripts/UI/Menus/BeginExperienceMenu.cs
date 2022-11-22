using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeginExperienceMenu : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nameField;
    [SerializeField] private Button _beginButton;


    private void Start()
    {
        _beginButton.onClick.AddListener(BeginExperience);
    }


    private void BeginExperience()
    {
        if (string.IsNullOrEmpty(_nameField.text)) return;

        SessionData.StartNewSession(_nameField.text);

        SceneLoader.Instance.LoadScene(1);
    }
}
