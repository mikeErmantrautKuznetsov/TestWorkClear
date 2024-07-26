using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour, ICameraController
{
    [SerializeField]
    private Transform playerBody;

    private float mouseSensivety = 500f;

    private float xRotation;

    private void Start()
    {
        playerBody = GetComponent<Transform>();
    }

    public void cameraRotation()
    {
        float horizontal = Input.GetAxis("Mouse X") * mouseSensivety * Time.deltaTime;

        xRotation -= horizontal;
        xRotation = Mathf.Clamp(xRotation, xRotation, xRotation);

        transform.localRotation = Quaternion.Euler(0f, -xRotation, 0f);
        playerBody.Rotate(Vector3.up * horizontal);
    }
}
