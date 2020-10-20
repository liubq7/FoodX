using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTap : MonoBehaviour
{
    public GameObject Dish;
    public static bool pick;
    public static bool[] SushiMenu, DessertMenu, DrinkMenu, ChinesefoodMenu;

    // Start is called before the first frame update
    void Start()
    {
        SushiMenu = new bool[4];
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
                    int n = int.Parse(Dish.name);
                    Order(n);
                    // Dish.SetActive(false);
                }
            }
        }
    }

    public void Order(int n)
    {
        SushiMenu[n] = true;
        pick = true;
    }
}
