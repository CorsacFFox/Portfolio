using UnityEngine;

public class PillarScript : MonoBehaviour, IInteractable
{
    public DataStorage storage;
    private AudioSource sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    public string GetDescription()
    {
        return "Активировать портал [E]";
    }

    public void Interact()
    {
        sound.Play();
        storage.gate_activated = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
