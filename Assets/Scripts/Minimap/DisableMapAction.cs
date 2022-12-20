using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DisableMapAction : MonoBehaviour
{
    
    void Start()
    {
        FindObjectOfType<MinimapControl>().SetMinimapActive(false);
   }

}
