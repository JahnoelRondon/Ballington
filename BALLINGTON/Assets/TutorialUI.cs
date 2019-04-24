using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void reloadTutorial()
    {
        SceneManager.LoadScene("TutorialWorld");
    }
}
