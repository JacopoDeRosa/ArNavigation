using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPromptAction : MonoBehaviour
{
   
    void Start()
    {
        FindObjectOfType<PromptManager>().ResetPromptText();
    }

}
