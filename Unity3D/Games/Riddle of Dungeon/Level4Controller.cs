using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level4Controller : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.5f;

    internal bool[] leversStatus = {false, false, false};
    public GameObject[] platforms;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn(2, 1, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeIn(0, 0, 1));
            //SceneManager.LoadScene(0);
        }
    }

    public void checkLever(string name)
    {
        switch (name) 
        {
            case "Lever1":
                leversStatus[0] = true;
                break;
            case "Lever2":
                leversStatus[1] = true;
                break;
            case "Lever3":
                leversStatus[2] = true;
                break;
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
            SceneManager.LoadScene(0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (leversStatus[0] == true && platforms[0].transform.position.x != 0)
        {
            Vector3 targetPosition = new Vector3(0, platforms[0].transform.position.y, platforms[0].transform.position.z);

            Vector3 movement = Vector3.MoveTowards(platforms[0].transform.position, targetPosition, 1 * Time.deltaTime);

            platforms[0].transform.position = movement;

        }
        if (leversStatus[1] == true && platforms[1].transform.position.x != 0)
        {
            Vector3 targetPosition = new Vector3(0, platforms[1].transform.position.y, platforms[1].transform.position.z);

            Vector3 movement = Vector3.MoveTowards(platforms[1].transform.position, targetPosition, 1 * Time.deltaTime);

            platforms[1].transform.position = movement;
        }
        if (leversStatus[2] == true && platforms[2].transform.position.x != 0)
        {
            Vector3 targetPosition = new Vector3(0, platforms[2].transform.position.y, platforms[2].transform.position.z);

            Vector3 movement = Vector3.MoveTowards(platforms[2].transform.position, targetPosition, 1 * Time.deltaTime);

            platforms[2].transform.position = movement;
        }
    }
}
