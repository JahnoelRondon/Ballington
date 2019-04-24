using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestPause : MonoBehaviour
{   
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject Pausebutton;
    [SerializeField] GameObject Pausewin;
    private Animator _pauseAnimator;
    // end animator
    private Animator _pauseEndaminator;

    void Start()
    {
        _pauseAnimator = GameObject.Find("PauseMenu").GetComponent<Animator>();
        _pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;

        //end animator
        _pauseEndaminator = GameObject.Find("PauseWin").GetComponent<Animator>();
        _pauseEndaminator.updateMode = AnimatorUpdateMode.UnscaledTime;
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
        //time is still frozen if time isnt set back to 1 at any point in time it was set to 0
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

    public void FinishLine()
    {
        Time.timeScale = 0f;
        Pausewin.SetActive(true);
        _pauseEndaminator.SetBool("isPaused", true);
    }

    public void ReplayLevel1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("World1");
    }

    public void pauseQuit()
    {
        Application.OpenURL("https://jayyron.itch.io/");
    }

}
