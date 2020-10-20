using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddedList : MonoBehaviour
{
    
    public Text[] SushiLabel, DessertLabel, DrinkLabel, ChinesefoodLabel;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            
            if (DoubleTap.SushiMenu[i] == true)
            {
                SushiLabel[i].color = Color.yellow;
            }
            if (DoubleTap.DessertMenu[i] == true)
            {
                DessertLabel[i].color = Color.yellow;
            }
            if (DoubleTap.DrinkMenu[i] == true)
            {
                DrinkLabel[i].color = Color.yellow;
            }
            if (DoubleTap.ChinesefoodMenu[i] == true)
            {
                ChinesefoodLabel[i].color = Color.yellow;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
