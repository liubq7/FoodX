using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public Button mButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void sceneChange(int i)
    {
        Application.LoadLevel(i);
    }
}
