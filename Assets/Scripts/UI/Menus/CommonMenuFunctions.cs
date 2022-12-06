using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonMenuFunctions : MonoBehaviour
{
   public void LoadMainMenu()
    {
        SceneLoader.Instance.LoadScene(0);
    }

   public void LoadScene(int index)
   {
       SceneLoader.Instance.LoadScene(index);
   }
}
