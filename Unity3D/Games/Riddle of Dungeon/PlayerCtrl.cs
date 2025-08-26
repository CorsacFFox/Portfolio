using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] private KeyCode runKey = KeyCode.LeftShift;
    [SerializeField] private KeyCode lightKey = KeyCode.F;

    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 5.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;
    private float walkSpeed = 5.0f;
    private float runMultiplier = 1.5f;

    private bool isRunning;


    public GameObject lantern;
    private float startIntensity;
    private float timeElapsed;
    public Light lightSource;
    public float targetRange = 5.35f;
    public float duration = 1.5f;
    private bool isOn = true;

    public Camera cam;
    public GameObject cam_GO;
    public CinemachineVirtualCamera virtualCamera;
    public float fovIncreaseRate = 1f;
    public float maxFov = 60f;
    private float targetFov;

    public bool can_move = true;
    internal bool lightCanBeEnabled = true;

    private AudioSource audioSource;
    public AudioClip[] footstepSounds;
    private string currentSurface;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        audioSource = GetComponent<AudioSource>();
    }

    private void enableLight()
    {
        //Debug.Log("Lantern dis-enabled");
        lantern.SetActive(!lantern.activeSelf);
    }

    private void CheckSurface()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, groundDistance + 2f))
        {
            Debug.DrawRay(transform.position, Vector3.down * (groundDistance + 1f), Color.red);
            currentSurface = hit.collider.tag;
        }
    }

    private void PlayFootstepSound()
    {
        AudioClip clipToPlay = null;
        switch (currentSurface)
        {
            case "Ground":
                if (isRunning)
                {
                    clipToPlay = footstepSounds[2];
                }
                else
                {
                    clipToPlay = footstepSounds[0];
                }
                break;
            case "Stone":
                if (isRunning)
                {
                    clipToPlay = footstepSounds[3];
                }
                else
                {
                    clipToPlay = footstepSounds[1];
                }
                break;
        }

        if (clipToPlay != null)
        {
            audioSource.PlayOneShot(clipToPlay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(lightKey) && lightCanBeEnabled)
        {
            Debug.Log("Light switched");
            isOn = !isOn;
            timeElapsed = 0;
        }
        if (lightSource != null)
        {
            if (isOn && lightSource.range < targetRange)
            {
                lantern.SetActive(true);
                timeElapsed += Time.deltaTime;
                float t = Mathf.Clamp01(timeElapsed / duration);
                lightSource.range = Mathf.Lerp(0, targetRange, t);
            }
            else if (!isOn && lightSource.intensity > 0)
            {
                timeElapsed += Time.deltaTime;
                float t = Mathf.Clamp01(timeElapsed / duration);
                lightSource.range = Mathf.Lerp(targetRange, 0, t);
                if (lightSource.range == 0)
                {
                    lantern.SetActive(false);
                }
            }
        }

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

            CheckSurface();

            if (groundedPlayer && (x != 0 || z != 0) && !audioSource.isPlaying)
            {
                PlayFootstepSound();
            }

            if (isRunning)
            {
                if (targetFov < maxFov)
                {
                    targetFov += fovIncreaseRate * Time.deltaTime * 60;
                }
                if (groundedPlayer)
                {
                    cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                    cam_GO.GetComponent<CameraBob>().bobSpeed = 30f;
                }
                else
                {
                    cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                    cam_GO.GetComponent<CameraBob>().bobSpeed = 2f;
                }
            }
            else
            {
                targetFov = Mathf.Lerp(targetFov, 75f, Time.deltaTime * 2f);

                cam_GO.GetComponent<CameraBob>().bobAmount = 0.1f;
                cam_GO.GetComponent<CameraBob>().bobSpeed = 2f;

            }
            if (virtualCamera != null)
            {
                virtualCamera.m_Lens.FieldOfView = targetFov;
            }
            else
            {
                cam.fieldOfView = targetFov;
            }

            Vector3 move = transform.right * x + transform.forward * z;

            if (move.magnitude > 1)
            {
                move.Normalize();
            }

            controller.Move(move * Time.deltaTime * playerSpeed);


            if (Input.GetButton("Jump") && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }



        }
        controller.Move(playerVelocity * Time.deltaTime);
    }
}