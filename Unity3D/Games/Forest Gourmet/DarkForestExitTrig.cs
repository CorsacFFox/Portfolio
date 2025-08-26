using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DarkForestExitTrig : MonoBehaviour
{
    public RawImage fadeImage;
    public float fadeDuration = 0.5f;

    public DataStorage storage;

    public TMP_Text key_ui;

    private GameObject[] chests;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("KeyChest");
       
        foreach (GameObject objectWithTag in objectsWithTag)
        {
            int randomIndex = Random.Range(0, 2);
            if (randomIndex == 0)
            {
                objectsWithTag[randomIndex].SetActive(false);
            }
        }
        StartCoroutine(FadeIn(0, 1, 0));
        key_ui.text = storage.keys.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FadeIn(0, 0, 1));
        }
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
