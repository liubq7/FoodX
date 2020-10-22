using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyDrag : MonoBehaviour
{
    //public Button mButton;
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // create ray from the camera and passing through the touch position:
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            // create a logical plane at this object's position
            // and perpendicular to world Y:
            Plane plane = new Plane(Vector3.up, transform.position);
            float distance = 0; // this will return the distance from the camera
            if (plane.Raycast(ray, out distance))
            { // if plane hit...
                Vector3 pos = ray.GetPoint(distance); // get the point
                transform.position = pos;                                      // pos has the position in the plane you've touched
            }
        }
    }
}

