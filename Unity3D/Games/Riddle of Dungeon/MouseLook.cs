using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensitivity = 1.0f;
    public Transform playerBody;
    internal float xRotation = 0f;
    public bool can_rotate = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {    
        if (can_rotate)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }    
    }
}
