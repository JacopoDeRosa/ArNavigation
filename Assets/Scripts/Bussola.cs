using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
   public Transform playerTransform;
   public GameObject waypoints;

    void Update()
    {
       
        playerTransform = waypoints.GetComponentsInChildren<Transform>()[1];
        Vector3 targetPos = playerTransform.position-transform.position;
        targetPos.y = 0;
        float singleStep = 5f * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetPos, singleStep, 0.0f);  
        transform.rotation = Quaternion.LookRotation(newDirection);    
    }
}
