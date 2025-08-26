using TMPro;
using UnityEngine;

public class KeyChestSript : MonoBehaviour, IInteractable
{
    public DataStorage storage;
    public TMP_Text key_ui;
    public string GetDescription()
    {
        return "Сундук с ключом [Е]";
    }

    public void Interact()
    {
        gameObject.SetActive(false);
        storage.addKey();
        key_ui.text = storage.keys.ToString();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        key_ui = GameObject.FindGameObjectWithTag("keyUi").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
