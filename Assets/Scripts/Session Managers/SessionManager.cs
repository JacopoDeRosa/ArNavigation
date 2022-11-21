using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SessionManager : MonoBehaviour
{
    [SerializeField] private GameObject _endGameMenu;
    [SerializeField] private TMP_Text _content, _title;
    
    public void EndSession()
    {
        _endGameMenu.SetActive(true);
        _content.text = SessionData.GetSessionData();
        _title.text = "Dati Sessione: " + SessionData.UserName;
    }
}
