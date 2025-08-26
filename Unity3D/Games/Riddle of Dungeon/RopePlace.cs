using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePlace : MonoBehaviour
{
    public GameObject ropeOnStick;
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
        if (other.CompareTag("Rope"))
        {
            stickRb.isKinematic = false;
            stickIPU.enabled = true;
            other.gameObject.GetComponent<ItemPickingUp>().stopDragging();
            ropeOnStick.SetActive(true);
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
