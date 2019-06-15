using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void STARTGAME()
    {
        SceneManager.LoadScene("Monde1_1");
    }

    public void LEAVEGAME()
    {
        Application.Quit();
    }
}
