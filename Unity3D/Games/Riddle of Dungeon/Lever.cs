using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour, IInteractable
{
    public Level3Controller L3C;
    private bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string GetDescription()
    {
        if (!activated)
        {
            return "Старый рычаг [E]";
        }
        else
        {
            return "Старый рычаг";
        }
        
    }
    public void Interact()
    {
        if (!activated) {
            gameObject.GetComponent<Animation>().Play();
            L3C.activateLever();
            activated = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
