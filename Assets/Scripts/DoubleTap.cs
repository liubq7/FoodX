using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTap : MonoBehaviour
{
    public GameObject Dish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (Input.GetTouch(i).tapCount == 2)
                {
                    int n = Int32.Parse(Dish.name);
                    Order(n);
                }
            }
        }
    }

    public void Order(int n)
    {
        AddedList.SushiMenu[i] = true;
    }
}
