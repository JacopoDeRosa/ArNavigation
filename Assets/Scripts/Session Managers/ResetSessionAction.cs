using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSessionAction : MonoBehaviour
{
    void Start()
    {
       string name = SessionData.UserName;

        SessionData.StartNewSession(name);

    }
}
