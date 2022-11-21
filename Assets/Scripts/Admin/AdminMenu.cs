using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdminMenu : MonoBehaviour
{
    
    [SerializeField] private TMP_InputField _mail, _outMail, _password, _smpt, _port;

    private void Awake()
    {
        _mail.onEndEdit.AddListener(SetMail);
        _outMail.onEndEdit.AddListener(SetOutMail);
        _password.onEndEdit.AddListener(SetPassword);
        _smpt.onEndEdit.AddListener(SetServer);
        _port.onEndEdit.AddListener(SetPort);
    }

    private void OnEnable()
    {

        if(PlayerPrefs.HasKey(PrefKeys.k_mail))
        {
            _mail.text = PlayerPrefs.GetString(PrefKeys.k_mail);
        }
        else
        {
            _mail.text = "j.derosa@rbw-cgi.it";
            PlayerPrefs.SetString(PrefKeys.k_mail, "j.derosa@rbw-cgi.it");
        }

        if(PlayerPrefs.HasKey(PrefKeys.k_out))
        {
            _outMail.text = PlayerPrefs.GetString(PrefKeys.k_out);
        }
        else
        {
            _outMail.text = "Jacopo.DeRosa00@gmail.com";
            PlayerPrefs.SetString(PrefKeys.k_out, "Jacopo.DeRosa00@gmail.com");
        }

        if (PlayerPrefs.HasKey(PrefKeys.k_password))
        {
            _password.text = PlayerPrefs.GetString(PrefKeys.k_password);
        }
        else
        {
            _password.text = "zmegaeflteceqdjk";
            PlayerPrefs.SetString(PrefKeys.k_password, "zmegaeflteceqdjk");
        }

        if (PlayerPrefs.HasKey(PrefKeys.k_smpt))
        {
            _smpt.text = PlayerPrefs.GetString(PrefKeys.k_smpt);
        }
        else
        {
            _smpt.text = "smtp.gmail.com";
            PlayerPrefs.SetString(PrefKeys.k_smpt, "smtp.gmail.com");
        }

        if (PlayerPrefs.HasKey(PrefKeys.k_port))
        {
            _port.text = PlayerPrefs.GetInt(PrefKeys.k_port).ToString();
        }
        else
        {
            _port.text = "587";
            PlayerPrefs.SetInt(PrefKeys.k_port, 587);
        }
    }

    private void SetMail(string mail)
    {
        PlayerPrefs.SetString(PrefKeys.k_mail, mail);
    }

    private void SetOutMail(string mail)
    {
        PlayerPrefs.SetString(PrefKeys.k_out, mail);
    }

    private void SetPassword(string pass)
    {
        PlayerPrefs.SetString(PrefKeys.k_password, pass);
    }

    private void SetServer(string server)
    {
        PlayerPrefs.SetString(PrefKeys.k_smpt, server);
    }

    private void SetPort(string port)
    {
        PlayerPrefs.SetInt(PrefKeys.k_port, int.Parse(port));
    }
}