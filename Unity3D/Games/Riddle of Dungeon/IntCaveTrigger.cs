using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntCaveTrigger : MonoBehaviour, IInteractable
{
    public Image fadeImage;
    public float fadeDuration = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public string GetDescription()
    {
        return "Войти [E]";
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
            SceneManager.LoadScene(2);
        }

    }

    public void Interact()
    {
        StartCoroutine(FadeIn(0, 0, 1));


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
