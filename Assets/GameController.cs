using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject CameraTop;
    //public GameObject CameraFront;
    bool IsSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
