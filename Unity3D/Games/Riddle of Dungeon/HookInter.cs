using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookInter : MonoBehaviour
{
    public Level3Controller L3C;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        if (collision.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Collided with hand");
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
