using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackHome : MonoBehaviour
{
    public Button mButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = mButton.GetComponent<Button>();
        btn.onClick.AddListener(OnPress);
    }

     void OnPress()
    {
        Application.LoadLevel(0);
    }
}
