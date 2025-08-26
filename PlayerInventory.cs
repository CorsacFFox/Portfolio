using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PlayerInventory : MonoBehaviour
{
    public GameObject invetory_ui;
    public GameObject player_camera;
    private MouseLook mouse;
    public DataStorage storage;

    public TMP_Text dough;
    public TMP_Text tomato;
    public TMP_Text egg;
    public TMP_Text meat;
    public TMP_Text potato;
    public TMP_Text cabbage;
    public TMP_Text sourCream;

    public TMP_Text bagel;
    public TMP_Text friedPotato;
    public TMP_Text steak;
    public TMP_Text ramen;
    public TMP_Text pizza;
    public TMP_Text borsh;
    public TMP_Text dumplings;
    public TMP_Text shawarma;

    public GameObject kettle_ui;

    public TMP_Text stamina_ui;
    public Slider stamina_slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mouse = player_camera.GetComponent<MouseLook>();
        
    }

    public void useBagel()
    {
        if (storage.bagel > 0)
        {
            storage.UseMeal("Бублик", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useFried()
    {
        if (storage.friedPotato > 0)
        {
            storage.UseMeal("Картофель фри", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useSteak()
    {
        if (storage.steak > 0)
        {
            storage.UseMeal("Стейк", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useRamen()
    {
        if (storage.ramen > 0)
        {
            storage.UseMeal("Рамен", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void usePizza()
    {
        if (storage.pizza > 0)
        {
            storage.UseMeal("Пицца", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useBorsh()
    {
        if (storage.borsh > 0)
        {
            storage.UseMeal("Борщ", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useDumplings()
    {
        if (storage.dumplings > 0)
        {
            storage.UseMeal("Пельмени", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }
    public void useShawarma()
    {
        if (storage.shawarma > 0)
        {
            storage.UseMeal("Шаурма", true);
            updateInventroy();
            stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
            stamina_slider.value = storage.current_stamina;
        }
    }

    public void updateInventroy()
    {
        bagel.text = "Количество: " + storage.bagel;
        friedPotato.text = "Количество: " + storage.friedPotato;
        steak.text = "Количество: " + storage.steak;
        ramen.text = "Количество: " + storage.ramen;
        pizza.text = "Количество: " + storage.pizza;
        borsh.text = "Количество: " + storage.borsh;
        dumplings.text = "Количество: " + storage.dumplings;
        shawarma.text = "Количество: " + storage.shawarma;

        dough.text = "Тесто: " + storage.dough;
        tomato.text = "Помидоры: " + storage.tomato;
        egg.text = "Яйца: " + storage.egg;
        meat.text = "Мясо: " + storage.meat;
        potato.text = "Картофель: " + storage.potato;
        cabbage.text = "Капуста: " + storage.cabbage;
        sourCream.text = "Сметана: " + storage.sourCream;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !kettle_ui.activeSelf)
        {
            
            invetory_ui.SetActive(!invetory_ui.activeSelf);
            Cursor.lockState = invetory_ui.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
            mouse.can_rotate = !invetory_ui.activeSelf;

            updateInventroy();


        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            invetory_ui.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            mouse.can_rotate = true;
        }

    }
}
