using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalTrig : MonoBehaviour
{
    public GameObject straightUpRay;
    public GameObject crystal;
    public GameObject crystalLight;
    public Level3Controller L3C;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crystal"))
        {
            if (gameObject.name == "TrigMain")
            {
                straightUpRay.SetActive(false);
            }
            crystal.SetActive(true);
            crystalLight.SetActive(true);
            other.GetComponent<ItemPickingUp>().isDragging = false;
            Destroy(other.gameObject);
            L3C.checkCrystals();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
