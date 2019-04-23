using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject Pausebutton;
    private Animator _pauseAnimator;

    void Start()
    {
        _pauseAnimator = GameObject.Find("PauseMenu").GetComponent<Animator>();
        _pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    public void goToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void toTutorial()
    {
        SceneManager.LoadScene("TutorialWorld");
        Destroy(GameObject.Find("GameMaster"));
        //player is frozen if time isnt set back to 1
        Time.timeScale = 1f;
    }

    public void resumePlay()
    {
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
        Pausebutton.SetActive(true);
        _pauseAnimator.SetBool("isPaused", false);      
    }

    public void pauseGame()
    {

        Time.timeScale = 0f;
        PauseScreen.SetActive(true);
        Pausebutton.SetActive(false);
        _pauseAnimator.SetBool("isPaused", true);      
    }


    public void pauseQuit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }

}
