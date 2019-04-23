using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("World1");
    }

    

    public void Quit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }

}
