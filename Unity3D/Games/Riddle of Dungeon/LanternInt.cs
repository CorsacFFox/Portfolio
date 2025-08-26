using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternInt : MonoBehaviour, IInteractable
{
    public Level1Controller L1C;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Interact()
    {
        L1C.pickUpLantern();
        Destroy(gameObject);
    }
    public string GetDescription()
    {
        return "Фонарь [E]";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
