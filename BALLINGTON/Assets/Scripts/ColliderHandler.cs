using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderHandler : MonoBehaviour
{
    
    private PlayerMover _player;
    [SerializeField] private AudioClip _clipyay;

    private TestPause _pauseWin;
    private TutorialUI _tutorialUI;

    private SecretOrb _secretOrb;

    void Start()
    {
        _player = GetComponent<PlayerMover>();
        _pauseWin = GameObject.Find("Canvas").GetComponent<TestPause>();

        _tutorialUI = GameObject.Find("Canvas").GetComponent<TutorialUI>();

        _secretOrb = GameObject.Find("SecretLevel").GetComponent<SecretOrb>();
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "jumpAble":
                _player.isGrounded = true;
                break;

            case "WrongWay":
                _player.rb.velocity = Vector3.zero;
                transform.position = new Vector3(0, 3, -30);
                break;
        }
    }

    void OnCollisionExit(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "jumpAble":
                _player.isGrounded = false;

                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            //when making other levels Change water tag to death2, death3, death4 && load those levels
            case "Death":

                //invoke calling method works too
                StartCoroutine(LoadFirstLevel());
                

                //teleports player back to island instead of reloading scene
                
                //_player.rb.velocity = Vector3.zero;
               // transform.position = new Vector3(0.769f, 60.76f, -225.21f);
                break;

            case "Win":
                AudioSource.PlayClipAtPoint(_clipyay, Camera.main.transform.position);
                Time.timeScale = 0.5f;
                Invoke("WonGame", 2.5f);
                break;

            case "WrongWay":
                _player.rb.velocity = Vector3.zero;
                transform.position = new Vector3(0, 3, -30);
                break;

            case "EasterEgg":
                Time.timeScale = 0.5f;
                Invoke("EasterEggDeath", 1.5f);
                _secretOrb.StoleOrb();
                _tutorialUI.PlayFade();
                break;
        }
    }

    private void EasterEggDeath()
    {
        SceneManager.LoadScene("World1");
    }

    IEnumerator LoadFirstLevel()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("World1");
    }

    private void WonGame()
    {
        _pauseWin.FinishLine();
    }

}
