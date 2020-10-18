using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinksClick : MonoBehaviour
{
    public Button mButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = mButton.GetComponent<Button>();
        btn.onClick.AddListener(OnButtonPress);
    }

    private void OnButtonPress()
    {
        Application.LoadLevel(3);
    }
}
