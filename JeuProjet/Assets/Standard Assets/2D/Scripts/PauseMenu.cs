using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    bool showGUI = false;
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            showGUI = !showGUI;
        }

        if (showGUI)
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void OnLevelWasLoaded()
    {
        canvas = GameObject.Find("Canvas Pause");
    }

    public void LEAVEGAME()
    {
        Application.Quit();
    }

    public void LOADMAINMENU()
    {
        SceneManager.LoadScene("Main Menu");
    }
}