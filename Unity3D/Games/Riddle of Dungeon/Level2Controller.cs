using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    //public GameObject scene_camera;
    //public GameObject player_camera;
    //public GameObject main_camera;

    public Image fadeImage;
    public float fadeDuration = 1.5f;

    public GameObject player;

    public GameObject door;

    internal List<GameObject> runes = new List<GameObject>{null, null, null, null, null};
    //internal GameObject[] runes = {null, null, null, null, null};
    private int runeCounter = 0;
    private string[] rightSequence = { "Rune1", "Rune2", "Rune3", "Rune4", "Rune5" };
    
    private TextController TController;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //StartCoroutine(start_earthqueake());
        TController = GetComponent<TextController>();
        StartCoroutine(FadeIn(2f, 1, 0));
    }

    private IEnumerator FadeIn(float delay, int start, int end)
    {
        yield return new WaitForSeconds(delay);
        UnityEngine.Color color = fadeImage.color;
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
            SceneManager.LoadScene(3);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FadeIn(0f, 0, 1));
        }
    }

    public void connectRune(GameObject rune, int index)
    {
        runes[index] = rune.gameObject;
        runeCounter++;
        Debug.Log("Rune connected");
        if (runeCounter == 5)
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (runes[i].name != rightSequence[i])
                {
                    Debug.Log("Wrong Sequence" + i);

                    for (int k = 0; k < 5; k++)
                    {
                        Debug.Log("Rune" + (k+1).ToString());
                        GameObject a = GameObject.Find("Rune" + (k+1).ToString());
                        a.GetComponent<Rigidbody>().isKinematic = false;
                        a.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2f, ForceMode.Impulse);
                        a.GetComponent<ItemPickingUp>().enabled = true;
                        a.GetComponent<Outline>().enabled = true;
                    }

                    StartCoroutine(resetRunes());
                    runeCounter = 0;
                    return;
                }
            }
            door.GetComponent<Animation>().Play();
            Debug.Log("Right sequence, opening the door");
        }
        
    }
    private IEnumerator resetRunes()
    {
        yield return new WaitForSeconds(1f);
        runes = new List<GameObject> { null, null, null, null, null };
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Test button");
            
            
        }
    }
}
