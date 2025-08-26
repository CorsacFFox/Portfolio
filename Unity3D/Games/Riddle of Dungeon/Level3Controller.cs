using GogoGaga.OptimizedRopesAndCables;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3Controller : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.5f;

    public GameObject[] gears;
    public GameObject rope;
    
    private Rope ropeScript;
    private float timeElapsed = 0f;
    public float duration = 20.0f;

    public GameObject shield;
    private MeshCollider shieldCollider;
    private ItemPickingUp shieldPickUp;
    private Rigidbody shieldRb;

    private int guardianItems = 0;
    public AudioSource guardianAudio;
    public AudioClip guardianSecondSpeech;
    public AudioClip guardianThirdSpeech;

    public GameObject virtCamera;
    public GameObject virtCameraMain;
    //public GameObject playerCamera;
    public GameObject playerVirtCamera;
    private bool audioIsPlaying = false;
    public GameObject guardianHand;
    public GameObject guardianArmor;
    public GameObject guardianShield;
    public GameObject eyes;

    public TextController TController;

    internal bool leverIsDown = false;
    internal bool gearPlaced = false;

    public GameObject[] crystals;
    public GameObject[] crystalLightRays;
    private int crystalCount = 0;
    public GameObject badForce;

    public GameObject rightDoor;
    public GameObject leftDoor;


    // Start is called before the first frame update
    void Start()
    {
        ropeScript = rope.GetComponent<Rope>();
        shieldCollider = shield.GetComponent<MeshCollider>();
        shieldPickUp = shield.GetComponent<ItemPickingUp>();
        shieldRb = shield.GetComponent<Rigidbody>();
        StartCoroutine(FadeIn(2f, 1, 0));
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
        if(color.a == 1)
        {
            SceneManager.LoadScene(4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeIn(0f, 0, 1));
        }
    }

    public void addGuardianItem(string peaceName)
    {
        switch (peaceName)
        {
            case "Armor": 
                guardianArmor.SetActive(true); 
                break;
            case "Hand":
                guardianHand.SetActive(true);
                break;
            case "Shield":
                guardianShield.SetActive(true);
                break;
        }
        guardianItems++;
        if(guardianItems == 3)
        {
            //playerCamera.SetActive(false);
            //virtCameraMain.SetActive(true);
            playerVirtCamera.SetActive(false);
            virtCamera.SetActive(true);
            eyes.SetActive(true);
            
            guardianAudio.Play();
            audioIsPlaying = true;
        }
    }
    
    public void activateLever()
    {
        leverIsDown = true;
        if (gearPlaced)
        {
            for (int i = 0; i < gears.Length; i++)
            {                
                gears[i].GetComponent<GearSpinning>().enabled = true;               
            }
        }
        else
        {
            gears[0].GetComponent<GearSpinning>().enabled = true;
        }
        StartCoroutine(activateShield());
    }
    private IEnumerator activateShield()
    {   
        yield return new WaitForSeconds(1f);
        if (gearPlaced && leverIsDown)
        {
            shieldCollider.enabled = true;
            shieldPickUp.enabled = true;
            shieldRb.isKinematic = false;
        }       
    }
    public void placeGear()
    {
        gearPlaced = true;
        gears[1].SetActive(true);
        if (leverIsDown)
        {
            for (int i = 0; i < gears.Length; i++)
            {
                gears[i].GetComponent<GearSpinning>().enabled = true;              
            }
        }
        StartCoroutine(activateShield());
    }
    private IEnumerator disableCamera()
    {
        yield return new WaitForSeconds(0.1f);
        playerVirtCamera.SetActive(false);
        virtCamera.SetActive(true);
    }
    private IEnumerator enableCamera()
    {
        playerVirtCamera.SetActive(true);
        yield return new WaitForSeconds(1f);        
        //playerCamera.SetActive(true);
        virtCameraMain.SetActive(false);
        playerVirtCamera.SetActive(false);
    }

    private IEnumerator playSecondAudio()
    {
        yield return new WaitForSeconds(1.5f);
        guardianAudio.clip = guardianSecondSpeech;
        for (int i = 0; i < crystals.Length; i++)
        {
            crystals[i].SetActive(true);
        }
        guardianAudio.Play();       
    }

    private void playThirdAudio()
    {    
        guardianAudio.clip = guardianThirdSpeech;
        guardianAudio.Play();
        leftDoor.GetComponent<Animation>().Play();
        rightDoor.GetComponent<Animation>().Play();
    }
    public void giveHintAboutHand()
    {
        TController.ShowTextAndVignette("Это что, каменная рука на потолке?", 2f, "White");
    }

    private IEnumerator activateRays()
    {
        yield return new WaitForSeconds(2f);
        crystalLightRays[0].SetActive(true);
        yield return new WaitForSeconds(1f);
        crystalLightRays[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        crystalLightRays[2].SetActive(true);
        yield return new WaitForSeconds(2f);
        badForce.SetActive(false); 
        yield return new WaitForSeconds(1f);
        playThirdAudio();
    }

    public void checkCrystals()
    {
        crystalCount ++;
        if (crystalCount == 3) 
        {
            StartCoroutine(activateRays());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(leverIsDown && gearPlaced)
        {
            if (ropeScript.ropeLength > 17.2f)
            {
                timeElapsed += Time.deltaTime;
                float t = timeElapsed / duration;
                ropeScript.ropeLength = Mathf.Lerp(ropeScript.ropeLength, 17.2f, t);
            }
            
        }
        if (audioIsPlaying && !guardianAudio.isPlaying)
        {
            virtCamera.SetActive(false);
            playerVirtCamera.SetActive(true);
            //StartCoroutine(enableCamera());
            audioIsPlaying = false;
            //playerCamera.SetActive(true);
            StartCoroutine(playSecondAudio());
        }
    }
}
