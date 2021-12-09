using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    //Setting up cameras at the start of the scene
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Switching the cameras off and on when C is pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }
}
