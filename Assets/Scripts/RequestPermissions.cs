using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class RequestPermissions : MonoBehaviour
{
    void Start()
    {
       if(Permission.HasUserAuthorizedPermission(Permission.Camera) == false)
       {
            Permission.RequestUserPermission(Permission.Camera);
       }
    }

   
}
