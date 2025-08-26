using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;
public class KettleScript : MonoBehaviour, IInteractable
{
    public GameObject kettle_ui;

    public DataStorage dataStorage;

    public GameObject player_camera;
    private MouseLook mouse;

    public TMP_Text dough;
    public TMP_Text tomato;
    public TMP_Text egg;
    public TMP_Text meat;
    public TMP_Text potato;
    public TMP_Text cabbage;
    public TMP_Text sourCream;

    private List<string> ingredients = new List<string>();

    private Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>
    {
        { "Бублик", new List<string> { "Тесто" } },
        { "Картофель фри", new List<string> { "Картошка" } },
        { "Стейк", new List<string> { "Мясо" } },
        { "Пицца", new List<string> { "Помидор", "Тесто" } },
        { "Рамен", new List<string> { "Мясо", "Яйцо" } },
        { "Борщ", new List<string> { "Мясо", "Картошка", "Капуста" } },
        { "Пельмени", new List<string> { "Мясо", "Тесто", "Сметана" } },
        { "Шаурма", new List<string> { "Помидор", "Капуста", "Мясо", "Тесто" } }
    };

    public GameObject bagel_ui;
    public GameObject fried_ui;
    public GameObject steak_ui;
    public GameObject pizza_ui;
    public GameObject ramen_ui;
    public GameObject borsh_ui;
    public GameObject dumplings_ui;
    public GameObject shawarma_ui;

    private AudioSource bonus_sound;

    public AudioClip bonus_sound_clip;
    public AudioClip error_sound_clip;

    public TMP_Text stamina_ui;
    public Slider stamina_slider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mouse = player_camera.GetComponent<MouseLook>();
        bonus_sound = GetComponent<AudioSource>();
    }
    public void AddDough()
    {
        AddIngredient("Тесто");
    }
    public void AddTomato()
    {
        AddIngredient("Помидор");
    }
    public void AddEgg()
    {
        AddIngredient("Яйцо");
    }
    public void AddMeat()
    {
        AddIngredient("Мясо");
    }
    public void AddPotato()
    {
        AddIngredient("Картошка");
    }
    public void AddCabbage()
    {
        AddIngredient("Капуста");
    }
    public void AddSoar()
    {
        AddIngredient("Сметана");
    }
    private void AddIngredient(string ingredient)
    {
        if (!CanUseIngredient(ingredient))
        {
            Debug.Log($"Недостаточно {ingredient} для добавления в котёл.");
            return;
        }

        dataStorage.UseIngredient(ingredient);
        
        ingredients.Add(ingredient);
        Debug.Log($"{ingredient} добавлен в котёл.");
        ShowIngredients();

        dough.text = dataStorage.dough.ToString();
        tomato.text = dataStorage.tomato.ToString();
        egg.text = dataStorage.egg.ToString();
        meat.text = dataStorage.meat.ToString();
        potato.text = dataStorage.potato.ToString();
        cabbage.text = dataStorage.cabbage.ToString();
        sourCream.text = dataStorage.sourCream.ToString();
    }
    private bool CanUseIngredient(string ingredient)
    {
        switch (ingredient)
        {
            case "Тесто":
                return dataStorage.dough > 0;
            case "Помидор":
                return dataStorage.tomato > 0;
            case "Яйцо":
                return dataStorage.egg > 0;
            case "Мясо":
                return dataStorage.meat > 0;
            case "Картошка":
                return dataStorage.potato > 0;
            case "Капуста":
                return dataStorage.cabbage > 0;
            case "Сметана":
                return dataStorage.sourCream > 0;
            default:
                Debug.LogWarning("Неизвестный ингредиент: " + ingredient);
                return false;
        }
    }
    public void ShowIngredients()
    {
        if (ingredients.Count == 0)
        {
            Debug.Log("Котёл пуст.");
            return;
        }

        string ingredientList = "Содержимое котла: ";
        foreach (var ingredient in ingredients)
        {
            ingredientList += ingredient + ", ";
        }

        ingredientList = ingredientList.TrimEnd(',', ' ');
        Debug.Log(ingredientList);
    }

    public void Cook()
    {
        ShowIngredients();
        string result = CheckRecipe();
        if (!string.IsNullOrEmpty(result))
        {
            Debug.Log($"Блюдо готово: {result}!");
            dataStorage.AddMeal(result);
            bonus_sound.clip = bonus_sound_clip;
            bonus_sound.Play();
            switch (result)
            {
                case "Бублик":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    bagel_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Картофель фри":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    fried_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Стейк":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    steak_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Пицца":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    pizza_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Рамен":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    ramen_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Борщ":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    borsh_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Пельмени":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    dumplings_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;
                case "Шаурма":
                    dataStorage.AddIngredient(result);
                    clearUi();
                    shawarma_ui.SetActive(true);
                    StopAllCoroutines();
                    StartCoroutine(clearUiDelayed());
                    break;

            }
            ingredients.Clear();
        }
        else
        {
            bonus_sound.clip = error_sound_clip;
            bonus_sound.Play();
            if(dataStorage.max_stamina > 20 && dataStorage.max_stamina - 5 >= 20)
            {
                dataStorage.max_stamina -= 5;
                dataStorage.current_stamina -= 5;
                stamina_ui.text = ((int)dataStorage.current_stamina).ToString() + "/" + dataStorage.max_stamina.ToString();
                stamina_slider.maxValue = dataStorage.max_stamina;
                stamina_slider.value = dataStorage.current_stamina;
            }
            

            Debug.Log("Неправильная последовательность ингредиентов. Попробуйте снова.");
            ingredients.Clear();
        }
    }
    private IEnumerator clearUiDelayed()
    {
        yield return new WaitForSeconds(1f);
        bagel_ui.SetActive(false);
        fried_ui.SetActive(false);
        steak_ui.SetActive(false);
        pizza_ui.SetActive(false);
        ramen_ui.SetActive(false);
        borsh_ui.SetActive(false);
        dumplings_ui.SetActive(false);
        shawarma_ui.SetActive(false);
    }
    private void clearUi()
    {
        bagel_ui.SetActive(false);
        fried_ui.SetActive(false);
        steak_ui.SetActive(false);
        pizza_ui.SetActive(false);
        ramen_ui.SetActive(false);
        borsh_ui.SetActive(false);
        dumplings_ui.SetActive(false);
        shawarma_ui.SetActive(false);
    }
    private string CheckRecipe()
    {
        foreach (var recipe in recipes)
        {
            if (CheckIngredients(recipe.Value))
            {
                return recipe.Key;
            }
        }
        return null;
    }

    private bool CheckIngredients(List<string> recipe)
    {
        if (ingredients.Count != recipe.Count)
        {
            return false;
        }

        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i] != recipe[i])
            {
                return false;
            }
        }

        return true;
    }
    public void Interact()
    {
        Debug.Log("Interacted with kettle");
        kettle_ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = kettle_ui.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
        mouse.can_rotate = false;
        
        dough.text = dataStorage.dough.ToString();
        tomato.text = dataStorage.tomato.ToString();
        egg.text = dataStorage.egg.ToString();
        meat.text = dataStorage.meat.ToString();
        potato.text = dataStorage.potato.ToString();
        cabbage.text = dataStorage.cabbage.ToString();
        sourCream.text = dataStorage.sourCream.ToString();
    }



    // Update is called once per frame
    void Update()
    {
        if (kettle_ui.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.Locked;
                kettle_ui.SetActive(false);
                mouse.can_rotate = true;
            }
        }
    }

    public string GetDescription()
    {
        return "Котелок [E]";
    }
}
