using System.Collections;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using UnityEngine.UIElements;
using TMPro;

public class ChestScript : MonoBehaviour, IInteractable
{
    public DataStorage storage;
    private AudioSource chestSound;

    public GameObject dough_ui;
    public GameObject tomato_ui;
    public GameObject egg_ui;
    public GameObject meat_ui;
    public GameObject potato_ui;
    public GameObject cabbage_ui;
    public GameObject saur_ui;

    public TMP_Text key_ui;

    private string[] ingredients = {"Тесто", "Помидор", "Яйцо", "Мясо", "Картошка", "Капуста", "Сметана"};
    private float[] chances = { 25f, 12.5f, 6.2f, 31.2f, 12.5f, 6.3f, 6.3f };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chestSound = GetComponent<AudioSource>();
    }
    public string GetDescription()
    {
        return "Использовать ключ [E]";
    }
    private IEnumerator clearUiDelayed()
    {
        yield return new WaitForSeconds(1f);
        dough_ui.SetActive(false);
        tomato_ui.SetActive(false);
        egg_ui.SetActive(false);
        meat_ui.SetActive(false);
        potato_ui.SetActive(false);
        cabbage_ui.SetActive(false);
        saur_ui.SetActive(false);
    }
    private void clearUi()
    {
        dough_ui.SetActive(false);
        tomato_ui.SetActive(false);
        egg_ui.SetActive(false);
        meat_ui.SetActive(false);
        potato_ui.SetActive(false);
        cabbage_ui.SetActive(false);
        saur_ui.SetActive(false);
    }

    private string GetRandomIngredient()
    {
        float totalWeight = 0f;
        foreach (float chance in chances)
        {
            totalWeight += chance;
        }

        float randomValue = Random.Range(0f, totalWeight);
        float cumulativeWeight = 0f;

        for (int i = 0; i < ingredients.Length; i++)
        {
            cumulativeWeight += chances[i];
            if (randomValue < cumulativeWeight)
            {
                return ingredients[i];
            }
        }

        return ingredients[ingredients.Length - 1];
    }

    public void Interact()
    {   
        if(storage.keys > 0)
        {
            storage.keys--;
            key_ui.text = storage.keys.ToString();
            chestSound.Play();
            //int randomIndex = Random.Range(0, ingredients.Length);
            string ingredient = GetRandomIngredient();
            switch (ingredient)
            {
                case "Тесто":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    dough_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Помидор":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    tomato_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Яйцо":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    egg_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Мясо":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    meat_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Картошка":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    potato_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Капуста":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    cabbage_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Сметана":
                    storage.AddIngredient(ingredient);
                    clearUi();
                    saur_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;

            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
