using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    void Start()
    {
        Destroy(GameObject.Find("GameMaster"));
    }

    public void playGame()
    {
        SceneManager.LoadScene("World1");
    }

    public void playTutorial()
    {
        SceneManager.LoadScene("TutorialWorld");
    }
    

    public void Quit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }

}
