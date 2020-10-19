using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddedList : MonoBehaviour
{
    public static bool[] SushiMenu, DessertMenu, DrinkMenu, ChinesefoodMenu;
    public Text[] SushiLabel, DessertLabel, DrinkLabel, ChinesefoodLabel;
    // Start is called before the first frame update
    void Start()
    {
        SushiMenu = new bool[4];
        DessertMenu = new bool[4];
        DrinkMenu = new bool[4];
        ChinesefoodMenu = new bool[4];

    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < 4; i++)
        {
            if(SushiMenu[i] == true)
            {
                SushiLabel[i].color = Color.blue;
            }
            if(DessertMenu[i] == true)
            {
                DessertLabel[i].color = Color.blue;
            }
            if (DrinkMenu[i] == true)
            {
                DrinkLabel[i].color = Color.blue;
            }
            if (ChinesefoodMenu[i] == true)
            {
                ChinesefoodLabel[i].color = Color.blue;
            }
        }
    }
}
