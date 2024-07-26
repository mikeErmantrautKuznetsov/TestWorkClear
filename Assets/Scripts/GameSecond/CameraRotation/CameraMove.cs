using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private ICameraController controller;

    private void Awake()
    {
        controller = GetComponent<ICameraController>();
    }
    
    void Update()
    {
        controller.cameraRotation();
    }
}
