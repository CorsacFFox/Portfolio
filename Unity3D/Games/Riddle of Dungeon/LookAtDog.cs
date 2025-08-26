using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtDog : MonoBehaviour
{
    public GameObject lvl1Controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            lvl1Controller.GetComponent<Level1Controller>().play_look_at_dog_animation();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
