using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapControl : MonoBehaviour
{
   [SerializeField] private GameObject _minimap;

   public void SetMinimapActive(bool active)
   {
      _minimap.SetActive(active);
   }

   public void ToggleMinimap()
   {
      SetMinimapActive(!_minimap.activeSelf);
   }
   
}
