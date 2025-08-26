using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorCollision : MonoBehaviour
{
    public Level3Controller L3C;
    public GameObject armorLight;
    //private ItemPickingUp IPU;
    // Start is called before the first frame update
    void Start()
    {
        //IPU = GetComponent<ItemPickingUp>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Armor"))
        {
            other.gameObject.GetComponent<ItemPickingUp>().stopDragging();
            //IPU.enabled = false;
            L3C.addGuardianItem("Armor");
            Destroy(other.gameObject);
            Destroy(armorLight);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
