using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneChecker : MonoBehaviour
{
    private Level2Controller L2C;
    // Start is called before the first frame update
    void Start()
    {
        L2C = GameObject.FindWithTag("GameController").GetComponent<Level2Controller>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Rune"))
        {           
            string name = gameObject.name;
            
            switch (name)
            {
                case "Place1":
                    if (L2C.runes[0] == null)
                    {
                        Debug.Log(name);
                        collision.gameObject.GetComponent<ItemPickingUp>().stopDragging();
                        collision.gameObject.GetComponent<ItemPickingUp>().enabled = false;
                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        collision.gameObject.transform.position = transform.position;
                        collision.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
                        collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                        collision.gameObject.GetComponent<Outline>().enabled = false;
                        L2C.connectRune(collision.gameObject, 0);
                    }                   
                    return;
                case "Place2":
                    if (L2C.runes[1] == null)
                    {
                        Debug.Log(name);
                        collision.gameObject.GetComponent<ItemPickingUp>().stopDragging();
                        collision.gameObject.GetComponent<ItemPickingUp>().enabled = false;
                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        collision.gameObject.transform.position = transform.position;
                        collision.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
                        collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                        collision.gameObject.GetComponent<Outline>().enabled = false;
                        L2C.connectRune(collision.gameObject, 1);
                    }
                    return;
                case "Place3":
                    if (L2C.runes[2] == null)
                    {
                        Debug.Log(name);
                        collision.gameObject.GetComponent<ItemPickingUp>().stopDragging();
                        collision.gameObject.GetComponent<ItemPickingUp>().enabled = false;
                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        collision.gameObject.transform.position = transform.position;
                        collision.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
                        collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                        collision.gameObject.GetComponent<Outline>().enabled = false;
                        L2C.connectRune(collision.gameObject, 2);
                    }
                    return;
                case "Place4":
                    if (L2C.runes[3] == null)
                    {
                        Debug.Log(name);
                        collision.gameObject.GetComponent<ItemPickingUp>().stopDragging();
                        collision.gameObject.GetComponent<ItemPickingUp>().enabled = false;
                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        collision.gameObject.transform.position = transform.position;
                        collision.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
                        collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                        collision.gameObject.GetComponent<Outline>().enabled = false;
                        L2C.connectRune(collision.gameObject, 3);
                    }
                    return;
                case "Place5":
                    if (L2C.runes[4] == null)
                    {
                        Debug.Log(name);
                        collision.gameObject.GetComponent<ItemPickingUp>().stopDragging();
                        collision.gameObject.GetComponent<ItemPickingUp>().enabled = false;
                        collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                        collision.gameObject.transform.position = transform.position;
                        collision.gameObject.transform.position += new Vector3(-0.03f, 0, 0);
                        collision.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                        collision.gameObject.GetComponent<Outline>().enabled = false;
                        L2C.connectRune(collision.gameObject, 4);
                    }
                    return;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
