using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DishChange : MonoBehaviour
{
    public GameObject[] Dishs;
    public Text calTitle, ingredientTitle;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < Dishs.Length; i++)
        {
            Dishs[i].SetActive(false);
        }
;
    }

    public void SetDish(int v)
    {
        for (int i = 0; i < Dishs.Length; i++)
        {
            if (i == v)
            {
                Dishs[i].SetActive(true);
            }
            else
            {
                Dishs[i].SetActive(false);
            }
        }
        throw new NotImplementedException();
    }

    public void SetCalTitle(string cal)
    {
        calTitle.text = cal;
    }

    public void SetIngerdientTitle(string ingredient)
    {
        ingredientTitle.text = ingredient;
    }
}
