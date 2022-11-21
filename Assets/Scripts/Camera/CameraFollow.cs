using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject cameraTrget;

    void Update()
    {
        this.gameObject.transform.position = new Vector3(cameraTrget.transform.position.x, this.transform.position.y, cameraTrget.transform.position.z);
        

    }
}
