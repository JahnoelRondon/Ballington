using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] GameObject _menubutton;
    [SerializeField] GameObject _restartbutton;

    private Animator _fadeanimation;

    void Start()
    {
        _fadeanimation = GameObject.Find("FadeIn").GetComponent<Animator>();
        _fadeanimation.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    public void PlayFade()
    {
        _menubutton.SetActive(false);
        _restartbutton.SetActive(false);
        _fadeanimation.SetBool("TouchedEgg", true);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void reloadTutorial()
    {
        SceneManager.LoadScene("TutorialWorld");
    }
}
