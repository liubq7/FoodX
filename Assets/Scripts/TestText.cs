using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TestText : MonoBehaviour
{
    public static bool pick;
    public UnityEngine.UI.Text test;
     // Start is called before the first frame update
    void Start()
    {
        pick = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(pick);
        if (pick == true)
        {
            test.color = Color.red;
        }
    }
}
