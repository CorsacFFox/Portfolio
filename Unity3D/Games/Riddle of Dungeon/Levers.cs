using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour, IInteractable
{
    public Level4Controller L4C;
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
        if (!activated)
        {
            gameObject.GetComponent<Animation>().Play();
            //L4C.activateLever();
            L4C.checkLever(gameObject.name);
            activated = true;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
