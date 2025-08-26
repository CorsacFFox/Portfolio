using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void clickStart()
    {
        SceneManager.LoadScene(1);
    }
    public void clickLevels()
    {
        
    }
    public void clickSettings()
    {

    }
    public void clickExit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
