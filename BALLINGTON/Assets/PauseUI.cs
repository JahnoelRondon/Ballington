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


    public void pauseQuit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }
}
