using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
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
            SceneManager.LoadScene(4);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeIn(0, 0, 1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
