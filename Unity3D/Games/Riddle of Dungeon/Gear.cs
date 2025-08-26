using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    private Level3Controller L3C;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        L3C = GameObject.FindGameObjectWithTag("GameController").GetComponent<Level3Controller>();
    }
    private void OnTriggerEnter(Collider other)
    {     
        if (other.CompareTag("GearPlace"))
        {
            L3C.placeGear();
            gameObject.GetComponent<ItemPickingUp>().stopDragging();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
