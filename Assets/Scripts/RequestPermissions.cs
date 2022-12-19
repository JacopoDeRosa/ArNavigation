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

       if(Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead) == false)
       {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
       }

       if(Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite) == false)
        {
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
        }
    }

   
}
