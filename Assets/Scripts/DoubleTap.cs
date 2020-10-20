using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTap : MonoBehaviour
{
    public GameObject Dish;
    public static bool[] SushiList, DessertList, DrinkList, ChinesefoodList;
    

    // Start is called before the first frame update
    void Start()
    {
        SushiList = new bool[4];
        DessertList = new bool[4];
        DrinkList = new bool[4];
        ChinesefoodList = new bool[4];
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
                    string[] pickName = new string[2];
                    pickName = Dish.name.Split('-');
                    int dishCatogory = int.Parse(pickName[0]);
                    int dishPick = int.Parse(pickName[1]);
                    Order(dishCatogory, dishPick);
                    Dish.SetActive(false);
                }
            }
        }
    }

    public void Order(int i, int j)
    {
        switch (i)
        {
            case 0:
                SushiList[j] = true;
                break;
            case 1:
                DessertList[j] = true;
                break;
            case 2:
                DrinkList[j] = true;
                break;
            case 3:
                ChinesefoodList[j] = true;
                break;
            default:
                break;
        }
    }
}
