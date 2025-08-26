using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickingUp : MonoBehaviour
{
    private Camera mainCamera;
    private MouseLook mouseLook;

    internal bool isDragging = false;
    private Rigidbody rb;
    private Vector3 offset;
    private float dragDistance = 2.0f;
    private float moveSpeed = 5f;

    private bool isColliding = false;
    private Outline outline;

    private float smoothTime = 0.1f;
    private Vector3 currentVelocity = Vector3.zero;

    void Start()
    {
        mainCamera = Camera.main;
        
        rb = GetComponent<Rigidbody>();
        if (GameObject.FindGameObjectWithTag("VirtualCamera"))
        {
            mouseLook = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<MouseLook>();
        }
        else
        {
            mouseLook = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseLook>();
        }
        outline = GetComponent<Outline>();
    } 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isDragging)
        {
            stopDragging();
            return;
        }

        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit1;
        if (Physics.Raycast(ray, out hit1, 3f))
        {
            if (hit1.transform == transform)
            {
                outline.OutlineWidth = 2f;
                if (Input.GetKeyDown(KeyCode.Mouse0) && !isDragging)
                {
                    if (rb.isKinematic)
                    {
                        rb.isKinematic = false;
                    }
                    isDragging = true;
                    rb.useGravity = false;
                    rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }
            else
            {
                outline.OutlineWidth = 0f;
            }
        }
        else
        {
            outline.OutlineWidth = 0f;
        }


        if (isDragging)
        {
            float scrollInput = Input.GetAxis("Mouse ScrollWheel");
            if (scrollInput != 0)
            {
                dragDistance -= -scrollInput * 3f;
                dragDistance = Mathf.Clamp(dragDistance, 0.5f, 4f);
            }

            Vector3 targetPosition = mainCamera.transform.position + mainCamera.transform.forward * dragDistance + offset;

            if (Vector3.Distance(transform.position, targetPosition) > 0.05f)
            {
                Vector3 direction = (targetPosition - transform.position).normalized;
                rb.velocity = Vector3.Lerp(rb.velocity, direction * moveSpeed, Time.deltaTime * 6f);
            }
            else
            {
                rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Time.deltaTime * 25f);
            }

            if (Input.GetKey(KeyCode.Mouse2))
            {
                mouseLook.can_rotate = false;
                float mouseX = Input.GetAxis("Mouse X");
                float mouseY = Input.GetAxis("Mouse Y");
                
                if (mouseX != 0)
                {
                    Vector3 playerForward = Camera.main.transform.forward;
                    playerForward.y = 0;

                    Quaternion rotation = Quaternion.AngleAxis(mouseX * 2f, Vector3.up);
                    transform.rotation = rotation * transform.rotation;
                }

                if (mouseY != 0)
                {
                    Vector3 playerRight = Camera.main.transform.right;
                    transform.Rotate(playerRight, -mouseY * 2f, Space.World);
                }
                

            }
            
            if (Input.GetKeyUp(KeyCode.Mouse2))
            {
                mouseLook.can_rotate = true;
            }           
        }      
    }

    public void stopDragging()
    {
        isDragging = false;
        rb.useGravity = true;
        rb.constraints = RigidbodyConstraints.None;
        rb.isKinematic = false;
        mouseLook.can_rotate = true;
    }
}