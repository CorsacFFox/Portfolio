using UnityEngine;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Scriptable Objects/DataStorage")]
public class DataStorage : ScriptableObject
{
    [Header("Stamina")]
    public float max_stamina = 30;
    public float current_stamina = 30;
    [Header ("Keys")]
    public int keys = 0;

    [Header("Ingredients")]
    public int dough = 0;
    public int tomato = 0;
    public int egg = 0;
    public int meat = 0;
    public int potato = 0;
    public int cabbage = 0;
    public int sourCream = 0;

    [Header("Meals")]
    public int bagel = 0;
    public int friedPotato = 0;
    public int steak = 0;
    public int ramen = 0;
    public int pizza = 0;
    public int borsh = 0;
    public int dumplings = 0;
    public int shawarma = 0;

    [Header("Gate")]
    public bool gate_activated = false;

    public void addKey()
    {
        keys++;
    }
    public void useKey()
    {
        if (keys > 0)
        {
            keys--;
        }
    }
    public void AddIngredient(string ingredient, int amount = 1)
    {
        switch (ingredient)
        {
            case "Тесто":
                dough++;
                break;
            case "Помидор":
                tomato++;
                break;
            case "Яйцо":
                egg++;
                break;
            case "Мясо":
                meat++;
                break;
            case "Картошка":
                potato++;
                break;
            case "Капуста":
                cabbage++;
                break;
            case "Сметана":
                sourCream++;
                break;
            default:
                Debug.LogWarning("Неизвестный ингредиент: " + ingredient);
                break;
        }
    }
    public void UseIngredient(string ingredient, int amount = 1)
    {
        switch (ingredient)
        {
            case "Тесто":
                if (dough >= amount) dough -= amount;
                break;
            case "Помидор":
                if (tomato >= amount) tomato -= amount;
                break;
            case "Яйцо":
                if (egg >= amount) egg -= amount;
                break;
            case "Мясо":
                if (meat >= amount) meat -= amount;
                break;
            case "Картошка":
                if (potato >= amount) potato -= amount;
                break;
            case "Капуста":
                if (cabbage >= amount) cabbage -= amount;
                break;
            case "Сметана":
                if (sourCream >= amount) sourCream -= amount;
                break;
            default:
                Debug.LogWarning("Неизвестный ингредиент: " + ingredient);
                break;
        }
    }
    public void AddMeal(string meal, int amount = 1)
    {
        switch (meal)
        {
            case "Бублик":
                bagel += amount;
                break;
            case "Картофель фри":
                friedPotato += amount;
                break;
            case "Стейк":
                steak += amount;
                break;
            case "Пицца":
                pizza += amount;
                break;
            case "Рамен":
                ramen += amount;
                break;
            case "Борщ":
                borsh += amount;
                break;
            case "Пельмени":
                dumplings += amount;
                break;
            case "Шаурма":
                shawarma += amount;
                break;
            default:
                Debug.LogWarning("Неизвестное блюдо: " + meal);
                break;
        }
    }
    public void UseMeal(string meal, bool mainStage, int amount = 1)
    {
        Debug.Log(meal);
        switch (meal)
        {
            case "Бублик":
                if (bagel >= amount) bagel -= amount;
                if (mainStage)
                {
                    max_stamina += 5;
                }            
                current_stamina += 5;
                if(current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }               
                break;
            case "Картофель фри":
                if (friedPotato >= amount) friedPotato -= amount;
                if (mainStage)
                {
                    max_stamina += 7;
                }
                
                current_stamina += 7;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Стейк":
                if (steak >= amount) steak -= amount;
                if (mainStage)
                {
                    max_stamina += 10;
                }
                
                current_stamina += 10;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Пицца":
                if (pizza >= amount) pizza -= amount;
                if (mainStage)
                {
                    max_stamina += 15;
                }
                
                current_stamina += 15;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Рамен":
                if (ramen >= amount) ramen -= amount;
                if (mainStage)
                {
                    max_stamina += 20;
                }
                
                current_stamina += 20;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Борщ":
                if (borsh >= amount) borsh -= amount;
                if (mainStage)
                {
                    max_stamina += 20;
                }
                
                current_stamina += 20;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Пельмени":
                if (dumplings >= amount) dumplings -= amount;
                if (mainStage)
                {
                    max_stamina += 30;
                }
                
                current_stamina += 30;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            case "Шаурма":
                if (shawarma >= amount) shawarma -= amount;
                if (mainStage)
                {
                    max_stamina += 100;
                }
                
                current_stamina += 100;
                if (current_stamina > max_stamina)
                {
                    current_stamina = max_stamina;
                }
                break;
            default:
                Debug.LogWarning("Неизвестное блюдо: " + meal);
                break;
        }
    }
}
