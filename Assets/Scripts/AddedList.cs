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
        for (int j = 0; j < 4; j++)
        {
            if (DoubleTap.SushiList[j] == true)
            {
                SushiLabel[j].color = Color.yellow;
            }

            if (DoubleTap.DessertList[j] == true)
            {
                DessertLabel[j].color = Color.yellow;
            }

            if (DoubleTap.DrinkList[j] == true)
            {
                DrinkLabel[j].color = Color.yellow;
            }

            if (DoubleTap.ChinesefoodList[j] == true)
            {
                ChinesefoodLabel[j].color = Color.yellow;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
