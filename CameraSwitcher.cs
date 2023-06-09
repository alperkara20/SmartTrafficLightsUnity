using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera camera1;
    public Camera camera2;
    // Add more camera references as needed

    private void Start()
    {
        // Enable the main camera by default
        EnableCamera(mainCamera);
    }

    private void Update()
    {
        // Example: Switch to camera1 when pressing the "1" key
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(camera1);
        }

        // Example: Switch to camera2 when pressing the "2" key
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(camera2);
        }

        // Add more conditions and key inputs to switch to other cameras
    }

    private void EnableCamera(Camera camera)
    {
        // Disable all cameras
        mainCamera.enabled = false;
        camera1.enabled = false;
        camera2.enabled = false;
        // Disable other cameras here

        // Enable the specified camera
        camera.enabled = true;
    }
}
