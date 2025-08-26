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
            case "�����":
                dough++;
                break;
            case "�������":
                tomato++;
                break;
            case "����":
                egg++;
                break;
            case "����":
                meat++;
                break;
            case "��������":
                potato++;
                break;
            case "�������":
                cabbage++;
                break;
            case "�������":
                sourCream++;
                break;
            default:
                Debug.LogWarning("����������� ����������: " + ingredient);
                break;
        }
    }
    public void UseIngredient(string ingredient, int amount = 1)
    {
        switch (ingredient)
        {
            case "�����":
                if (dough >= amount) dough -= amount;
                break;
            case "�������":
                if (tomato >= amount) tomato -= amount;
                break;
            case "����":
                if (egg >= amount) egg -= amount;
                break;
            case "����":
                if (meat >= amount) meat -= amount;
                break;
            case "��������":
                if (potato >= amount) potato -= amount;
                break;
            case "�������":
                if (cabbage >= amount) cabbage -= amount;
                break;
            case "�������":
                if (sourCream >= amount) sourCream -= amount;
                break;
            default:
                Debug.LogWarning("����������� ����������: " + ingredient);
                break;
        }
    }
    public void AddMeal(string meal, int amount = 1)
    {
        switch (meal)
        {
            case "������":
                bagel += amount;
                break;
            case "��������� ���":
                friedPotato += amount;
                break;
            case "�����":
                steak += amount;
                break;
            case "�����":
                pizza += amount;
                break;
            case "�����":
                ramen += amount;
                break;
            case "����":
                borsh += amount;
                break;
            case "��������":
                dumplings += amount;
                break;
            case "������":
                shawarma += amount;
                break;
            default:
                Debug.LogWarning("����������� �����: " + meal);
                break;
        }
    }
    public void UseMeal(string meal, bool mainStage, int amount = 1)
    {
        Debug.Log(meal);
        switch (meal)
        {
            case "������":
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
            case "��������� ���":
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
            case "�����":
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
            case "�����":
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
            case "�����":
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
            case "����":
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
            case "��������":
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
            case "������":
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
                Debug.LogWarning("����������� �����: " + meal);
                break;
        }
    }
}
