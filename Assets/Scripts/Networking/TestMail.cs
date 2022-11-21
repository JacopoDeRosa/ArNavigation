using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMail : MonoBehaviour
{
    [SerializeField] private bool Test;

    private void Awake()
    {
        SessionData.StartNewSession("Jacopo De Rosa");
    }

    private void Update()
    {
        if(Test)
        {
            EmailSender.SendEmail(SessionData.UserName ,SessionData.GetSessionData());
            Destroy(gameObject);

        }
    }
}
