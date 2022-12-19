using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bussola : MonoBehaviour
{
    private SimpleWaypoint _activeWaypoint;

    void Update()
    {
        if(_activeWaypoint == null || _activeWaypoint.gameObject.activeInHierarchy == false)
        {
            FindNewWaypoint();
        }

        if(_activeWaypoint != null)
        {
            Vector3 myFlatPos = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 hisFlatPos = new Vector3(_activeWaypoint.transform.position.x, 0, _activeWaypoint.transform.position.z);

            Quaternion lookRot = Quaternion.LookRotation(hisFlatPos - myFlatPos);

            transform.rotation = Quaternion.Lerp(transform.rotation, lookRot, 3 * Time.deltaTime);
        }
    }

    private void FindNewWaypoint()
    {
        _activeWaypoint = FindObjectOfType<SimpleWaypoint>();
    }
}
