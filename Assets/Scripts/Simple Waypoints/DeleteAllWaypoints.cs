using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllWaypoints : MonoBehaviour
{
   
    void Start()
    {
      foreach(SimpleWaypoint waypoint in FindObjectsOfType<SimpleWaypoint>())
        {
            waypoint.gameObject.SetActive(false);
        }
    }
}
