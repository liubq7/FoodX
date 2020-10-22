using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleTap : MonoBehaviour
{
    public GameObject Dish;
    public Button gotoAddedList;

    public static int alreadyOrdered = 0;
    public static bool[] SushiList = new bool[4];
    public static bool[] DessertList = new bool[4];
    public static bool[] DrinkList = new bool[4];
    public static bool[] ChinesefoodList = new bool[4];

    public static double totalPrice = 0;
    public static double[] SushiPrice = { 2, 3, 3, 7 };
    public static double[] DessertPrice = { 1, 2, 2, 2 };
    public static double[] DrinkPrice = { 1.5, 3, 2, 1.5 };
    public static double[] ChinesefoodPrice = { 5, 5, 20, 10 };


    // Start is called before the first frame update
    void Start()
    {
        gotoAddedList.transform.Find("Text").GetComponent<Text>().text = alreadyOrdered.ToString();
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
                    // Dish.SetActive(false);
                    alreadyOrdered++;
                }
            }
        }
        gotoAddedList.transform.Find("Text").GetComponent<Text>().text = alreadyOrdered.ToString();
    }

    public void Order(int i, int j)
    {
        switch (i)
        {
            case 0:
                SushiList[j] = true;
                totalPrice += SushiPrice[j];
                break;
            case 1:
                DessertList[j] = true;
                totalPrice += DessertPrice[j];
                break;
            case 2:
                DrinkList[j] = true;
                totalPrice += DrinkPrice[j];
                break;
            case 3:
                ChinesefoodList[j] = true;
                totalPrice += ChinesefoodPrice[j];
                break;
            default:
                break;
        }
    }
}
