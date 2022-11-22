using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SessionManager : MonoBehaviour
{
    [SerializeField] private GameObject _endGameMenu;
    [SerializeField] private TMP_Text _content, _title;
    [SerializeField] private bool _sendResultMail;


    public void EndSession()
    {
        _endGameMenu.SetActive(true);
        _content.text = SessionData.GetSessionData();
        _title.text = "Dati Sessione: " + SessionData.UserName;

        if(_sendResultMail)
        {
            EmailSender.SendEmail(PlayerPrefs.GetString(PrefKeys.k_smpt), PlayerPrefs.GetString(PrefKeys.k_out), PlayerPrefs.GetString(PrefKeys.k_password), _title.text, SessionData.GetSessionData(), PlayerPrefs.GetInt(PrefKeys.k_port), PlayerPrefs.GetString(PrefKeys.k_mail));
        }
    }


}
