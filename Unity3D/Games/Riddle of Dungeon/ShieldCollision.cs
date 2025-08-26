using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public Level3Controller L3C;
    public GameObject shieldLight;
    // Start is called before the first frame update
    void Start()
    {
        //IPU = GetComponent<ItemPickingUp>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shield"))
        {
            other.gameObject.GetComponent<ItemPickingUp>().stopDragging();
            L3C.addGuardianItem("Shield");
            Destroy(other.gameObject);
            Destroy(shieldLight);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
