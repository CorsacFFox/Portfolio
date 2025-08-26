using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 10f;

    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void HandleInteraction()
    {
        Ray ray = mainCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                ShowInteractionUI(interactable);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
            else
            {
                HideInteractionUI();
            }
        }
        else
        {
            HideInteractionUI();
        }
    }

    private void ShowInteractionUI(IInteractable interactable)
    {
        interactionText.text = interactable.GetDescription();
        interactionUI.SetActive(true);
    }

    private void HideInteractionUI()
    {
        interactionUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //InteractionRay();
        HandleInteraction();
    }
    //void InteractionRay()
    //{
    //    Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
    //    RaycastHit hit;

    //    bool hitSomething = false;

    //    Debug.DrawRay(ray.origin, ray.direction * interactionDistance, Color.red, 0.1f);
    //    if (Physics.Raycast(ray, out hit, interactionDistance))
    //    {
    //        //Debug.DrawRay(ray.direction, hit.transform.position, Color.green, interactionDistance);

    //        Debug.DrawLine(ray.origin, hit.point, Color.green, 0.1f);
    //        IInteractable interactable = hit.collider.GetComponent<IInteractable>();
    //        if(interactable != null)
    //        {
    //            hitSomething = true;
    //            //Debug.Log("In interaction");
    //            interactionText.text = interactable.GetDescription();
    //            if (Input.GetKeyDown(KeyCode.E))
    //            {
    //                interactable.Interact();
    //            }
    //        }
    //    }
    //    interactionUI.SetActive(hitSomething);
    //}
    
}
