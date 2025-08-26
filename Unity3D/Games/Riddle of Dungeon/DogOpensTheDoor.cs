using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogOpensTheDoor : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            door.GetComponent<Animation>().Play();
            Debug.Log("Dog entered the trigger");
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
