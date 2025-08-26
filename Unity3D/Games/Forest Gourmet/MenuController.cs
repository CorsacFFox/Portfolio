using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public DataStorage storage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void pressPlay()
    {
        SceneManager.LoadScene("Main");
    }
    public void clearProgress()
    {
        storage.max_stamina = 20;
        storage.current_stamina = 20;

        storage.keys = 0;
        storage.dough = 0;
        storage.tomato = 0;
        storage.egg = 0;
        storage.meat = 0;
        storage.potato = 0;
        storage.cabbage = 0;
        storage.sourCream = 0;

        storage.bagel = 0;
        storage.friedPotato = 0;
        storage.steak = 0;
        storage.ramen = 0;
        storage.pizza = 0;
        storage.borsh = 0;
        storage.dumplings = 0;
        storage.shawarma = 0;

        storage.gate_activated = false;
    }
    public void addKeys()
    {
        storage.keys++;
    }
    public void gameQuit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
