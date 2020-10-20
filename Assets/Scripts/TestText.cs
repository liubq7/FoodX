using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestText : MonoBehaviour
{

    public Text test;
     // Start is called before the first frame update
    void Start()
    {
        test.text = DoubleTap.status;
        if(DoubleTap.pick == true)
        {
            test.color = Color.red;
            Debug.Log("success change color and text");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
