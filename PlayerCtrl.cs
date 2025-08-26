using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] private KeyCode runKey = KeyCode.LeftShift;
    //[SerializeField] private KeyCode lightKey = KeyCode.F;

    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 5.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;
    public float walkSpeed = 3f;
    public float runMultiplier = 1.8f;

    private bool isRunning;


    public GameObject lantern;
    private float startIntensity;
    private float timeElapsed;
    public Light lightSource;
    public float targetRange = 5.35f;
    public float duration = 1.5f;
    //private bool isOn = true;

    public Camera cam;
    public GameObject cam_GO;
    //public CinemachineVirtualCamera virtualCamera;
    public float fovIncreaseRate = 1f;
    public float maxFov = 60f;
    private float targetFov;

    public bool can_move = true;
    internal bool lightCanBeEnabled = true;

    //private AudioSource audioSource;
    //public AudioClip[] footstepSounds;
    //private string currentSurface;

    public DataStorage storage;
    public float staminaDrainRate = 1f;
    public TMP_Text stamina_ui;
    public Slider stamina_slider;
    private bool isMainScene = false;

    private CameraBob cameraBob;

    public RawImage fadeImage;
    public float fadeDuration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        cameraBob = cam_GO.GetComponent<CameraBob>();
        Cursor.lockState = CursorLockMode.Locked;
        storage.current_stamina = storage.max_stamina;
        if(SceneManager.GetActiveScene().name == "Main")
        {
            staminaDrainRate = 0;
            isMainScene = true;
        }
        else
        {
            isMainScene = false;
        }
        stamina_slider.maxValue = storage.max_stamina;
        stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
        stamina_slider.value = storage.current_stamina;
        
        //audioSource = GetComponent<AudioSource>();
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
  
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        if (can_move)
        {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            if (x != 0 || z != 0)
            {
                isRunning = Input.GetKey(runKey);
            }
            else
            {
                isRunning = false;
            }

            playerSpeed = walkSpeed * (isRunning ? runMultiplier : 1f);

            
            if (isRunning && storage.current_stamina > 0)
            {
                if (!isMainScene)
                {
                    staminaDrainRate = 2;
                }
                
                if (targetFov < maxFov)
                {
                    targetFov += fovIncreaseRate * Time.deltaTime * 60;
                }
                cameraBob.bobAmount = groundedPlayer ? 0.1f : 0.1f;
                cameraBob.bobSpeed = groundedPlayer ? 30f : 2f;
                //if (groundedPlayer)
                //{
                //    cameraBob.bobAmount = groundedPlayer ? 0.1f : 0.1f;
                //    cameraBob.bobSpeed = groundedPlayer ? 30f : 2f;
                //    cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                //    cam_GO.GetComponent<CameraBob>().bobSpeed = 30f;
                //}
                //else
                //{
                //    cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                //    cam_GO.GetComponent<CameraBob>().bobSpeed = 2f;
                //}
            }
            else
            {
                if (!isMainScene)
                {
                    staminaDrainRate = 1;
                }
                
                targetFov = Mathf.Lerp(targetFov, 75f, Time.deltaTime * 2f);

                cameraBob.bobAmount = 0.1f;
                cameraBob.bobSpeed = 2f;
                //cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                //cam_GO.GetComponent<CameraBob>().bobSpeed = 2f;

            }

            
            Vector3 move = transform.right * x + transform.forward * z;
                      

            if (move.magnitude > 1)
            {
                move.Normalize();
            }
            if (move.magnitude > 0.1f)
            {
                storage.current_stamina -= staminaDrainRate * Time.deltaTime;        
                storage.current_stamina = Mathf.Max(storage.current_stamina, 0);
                if (storage.current_stamina <= 0)
                {

                    StartCoroutine(FadeIn(0, 0, 1));
                    targetFov = Mathf.Lerp(targetFov, 75f, Time.deltaTime * 2f);

                    cameraBob.bobAmount = 0.1f;
                    cameraBob.bobSpeed = 2f;
                    
                }
                stamina_ui.text = ((int)storage.current_stamina).ToString() + "/" + storage.max_stamina.ToString();
                stamina_slider.value = storage.current_stamina;

            }
            if (storage.current_stamina > 0)
            {
                controller.Move(move * Time.deltaTime * playerSpeed);
            }

            if (Input.GetButton("Jump") && groundedPlayer && storage.current_stamina > 0)
            {
                
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }



        }
        controller.Move(playerVelocity * Time.deltaTime);
    }
}