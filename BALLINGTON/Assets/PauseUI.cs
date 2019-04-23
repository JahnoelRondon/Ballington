using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public void goToMain()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void resumePlay()
    {
        Time.timeScale = 1f;
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
    }

    public void pauseQuit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }
}
