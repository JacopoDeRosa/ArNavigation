using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchController : MonoBehaviour
{
    public GameObject CameraTop;
    //public GameObject CameraFront;
    bool IsSwitch;

    public void CameraSwitch()
    {
        IsSwitch =! IsSwitch;

       if(IsSwitch)
       {
            CameraTop.SetActive(true);  
       }
       else
       {
            CameraTop.SetActive(false);
        }
    }    
}
