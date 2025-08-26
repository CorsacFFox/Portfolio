using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    public DataStorage storage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collided");
        if(collision.gameObject.CompareTag("Player") && storage.current_stamina >= 400 && storage.gate_activated)
        {
            Debug.Log("you win");
            SceneManager.LoadScene("Menu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
