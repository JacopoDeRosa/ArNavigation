using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManagerOld : MonoBehaviour
{
    [SerializeField]
    TMP_Text toolTip;
    public static UiManager _instance { get; private set; }
    private void Awake()
    {
        if(FindObjectsOfType<UiManager>().Length>1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            //_instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setToolTip(string _toolTip)
    {
        toolTip.gameObject.SetActive(true);
        toolTip.text = _toolTip;
    }    

    public void resetToolTip()
    {
        toolTip.gameObject.SetActive(false);
    }
}
