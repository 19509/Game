using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    static bool GameIsPaused = false;

    static bool InHelp = false;

    public GameObject pauseMenuUI;

    public GameObject helpMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (InHelp)
            {
                LeaveHelp();
            }
            else
            {
                help();
            }
        }
    }

    public void LeaveHelp()
    {
        helpMenuUI.SetActive(false);
        Time.timeScale = 1f;
        InHelp = false;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }    

    void help()
    {
        helpMenuUI.SetActive(true);
        Time.timeScale = 0f;
        InHelp = true;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; ;
    }

    public void Resume ()
    {
        helpMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        InHelp = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        InHelp = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
