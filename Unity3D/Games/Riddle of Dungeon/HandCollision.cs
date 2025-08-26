using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    public Level3Controller L3C;
    public GameObject handLight;
    //private ItemPickingUp IPU;
    // Start is called before the first frame update
    void Start()
    {
        //IPU = GetComponent<ItemPickingUp>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            other.gameObject.GetComponent<ItemPickingUp>().stopDragging();
            //IPU.enabled = false;
            L3C.addGuardianItem("Hand");
            Destroy(other.gameObject);
            Destroy(handLight);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
