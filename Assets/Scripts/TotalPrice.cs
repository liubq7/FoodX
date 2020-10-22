using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPrice : MonoBehaviour
{
    public Button mButton;
    // Start is called before the first frame update
    void Start()
    {
        mButton.transform.Find("Text").GetComponent<Text>().text = "Ordered: " + System.Convert.ToString(DoubleTap.totalPrice);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
