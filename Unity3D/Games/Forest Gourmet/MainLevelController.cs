using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainLevelController : MonoBehaviour
{
    public DataStorage storage;

    public TMP_Text key_ui;

    public RawImage fadeImage;
    public float fadeDuration = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FadeIn(0, 1, 0));
        key_ui.text = storage.keys.ToString();
        //storage.coins = 0;
        //storage.dough = 0;
        //storage.tomato = 0;
        //storage.egg = 0;
        //storage.meat = 0;
        //storage.potato = 0;
        //storage.cabbage = 0;
        //storage.sourCream = 0;

        //storage.bagel = 0;
        //storage.friedPotato = 0;
        //storage.steak = 0;
        //storage.ramen = 0;
        //storage.pizza = 0;
        //storage.borsh = 0;
        //storage.dumplings = 0;
        //storage.shawarma = 0;
    }
    private IEnumerator FadeIn(float delay, int start, int end)
    {
        yield return new WaitForSeconds(delay);
        Color color = fadeImage.color;
        float elapsedTime = 0f;

        color.a = start;
        fadeImage.color = color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Lerp(start, end, elapsedTime / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        color.a = end;
        fadeImage.color = color;
        if (color.a == 1)
        {
            SceneManager.LoadScene("Main");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
