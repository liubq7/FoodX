using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DishChange : MonoBehaviour
{
    public GameObject[] Sushis;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < Sushis.Length; i++)
        {
            Sushis[i].SetActive(false);
        }
;
    }

    public void SetDish(int v)
    {
        for (int i = 0; i < Sushis.Length; i++)
        {
            if (i == v)
            {
                Sushis[i].SetActive(true);
            }
            else
            {
                Sushis[i].SetActive(false);
            }
        }
        throw new NotImplementedException();
    }


}
