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

    // Update is called once per frame
    void Update()
    {
        InteractionRay();
    }
    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitSomething = false;
        if(Physics.Raycast(ray, out hit, interactionDistance))
        {
            //Debug.DrawRay(ray.direction, hit.transform.position, Color.green, interactionDistance);

            
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if(interactable != null)
            {
                hitSomething = true;
                Debug.Log("In interaction");
                interactionText.text = interactable.GetDescription();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }
        interactionUI.SetActive(hitSomething);
    }
}
