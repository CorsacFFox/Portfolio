using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Level1Controller : MonoBehaviour
{
    //public GameObject scene_camera;
    public GameObject player_camera;
    //public GameObject main_camera;

    public GameObject scene_camera;

    public GameObject player;
    public GameObject book;
    public GameObject cave;
    public GameObject caveTrigger;

    public AudioSource earthquake;

    private Quaternion camera_rotation;

    private bool move_camera = false;
    private bool looking_at_cave = false;
    private bool looking_process_underway = false;

    private TextController TController;

    internal bool lanternPicked = false;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerCtrl>().lightCanBeEnabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(start_earthqueake());
        TController = GetComponent<TextController>();
    }
    
    public void play_look_at_dog_animation()
    {
        //scene_camera.GetComponent<Animation>().Play();
        scene_camera.GetComponent<Animation>().Play();
    }
    private IEnumerator start_earthqueake()
    {
        yield return new WaitForSeconds(2f);

        earthquake.Play();
        scene_camera.GetComponent<CameraShake>().TriggerShake();
        yield return new WaitForSeconds(0.5f);

        TController.ShowTextAndVignette("Что это? Землетрясение?", 2f, "White");
        yield return new WaitForSeconds(2.5f);

        book.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(2f);

        TController.ShowTextAndVignette("Дружок, стой!", 2f, "White");          
        yield return new WaitForSeconds(3f);

        scene_camera.GetComponent<CameraShake>().pause_earthquake();
        move_camera = true;
        TController.ShowTask("Догоните собаку");      
        player.GetComponent<CharacterController>().enabled = true;
        player.GetComponent<PlayerCtrl>().can_move = true;        
        yield return new WaitForSeconds(1f);

        player_camera.GetComponent<MouseLook>().can_rotate = true;
        player_camera.SetActive(true);
        scene_camera.SetActive(false);
        move_camera = false;
    }

    public void pickUpLantern()
    {
        player.GetComponent<PlayerCtrl>().lightCanBeEnabled = true;
        lanternPicked = true;
        caveTrigger.SetActive(true);
        TController.ShowTask("Зайдите в пещеру");
    }

    public void look_at_cave()
    {
        looking_at_cave = true;
        looking_process_underway = true;
        TController.ShowTextAndVignette("Дружок! Не иди туда!", 2f, "white");
        player_camera.GetComponent<MouseLook>().can_rotate = false;
        player.GetComponent<PlayerCtrl>().can_move = false;
        player_camera.GetComponent<CameraBob>().enabled = false;
        camera_rotation = player_camera.transform.rotation;
        StartCoroutine(stop_looking_at_cave());
    }
    private IEnumerator stop_looking_at_cave()
    {
        yield return new WaitForSeconds(3f);        
        looking_at_cave = false;

        yield return new WaitForSeconds(2f);
        TController.ShowTask("Подберите фонарь");
        TController.ShowTextAndVignette("Этой пещеры здесь не было. Мне стоит взять фонарь", 2f, "white");
        looking_process_underway = false;
        player.GetComponent<PlayerCtrl>().can_move = true;
        player_camera.GetComponent<MouseLook>().can_rotate = true;
        player_camera.GetComponent<CameraBob>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (move_camera)
        {
            scene_camera.transform.position = Vector3.Slerp(scene_camera.transform.position, player_camera.transform.position, 2 * Time.deltaTime); 
            scene_camera.transform.rotation = Quaternion.Slerp(scene_camera.transform.rotation, player_camera.transform.rotation, Time.deltaTime * 1.5f);
        }
        if (looking_process_underway)
        {
            if (looking_at_cave)
            {
                Vector3 directionToCave = (cave.transform.position - player_camera.transform.position).normalized;
                Quaternion targetRotation = Quaternion.LookRotation(directionToCave);
                player_camera.transform.rotation = Quaternion.Slerp(player_camera.transform.rotation, targetRotation, Time.deltaTime * 1.5f);

            }
            else
            {
                player_camera.transform.rotation = Quaternion.Slerp(player_camera.transform.rotation, camera_rotation, Time.deltaTime * 2f);
            }
        }
    }
}
