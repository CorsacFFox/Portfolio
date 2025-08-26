using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPlace : MonoBehaviour
{
    public GameObject ropePlace;

    public GameObject hookOnStick;
    public GameObject stick;
    private Rigidbody stickRb;
    private ItemPickingUp stickIPU;
    // Start is called before the first frame update
    void Start()
    {
        stickRb = stick.GetComponent<Rigidbody>();
        stickIPU = stick.GetComponent<ItemPickingUp>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hook"))
        {
            ropePlace.SetActive(true);
            stickRb.isKinematic = true;
            stickIPU.enabled = false;
            other.gameObject.GetComponent<ItemPickingUp>().stopDragging();
            hookOnStick.SetActive(true);
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
