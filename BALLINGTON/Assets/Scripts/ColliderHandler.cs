using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderHandler : MonoBehaviour
{
    
    private PlayerMover _player;
    [SerializeField] private AudioClip _clipyay;
        


    void Start()
    {
        _player = GetComponent<PlayerMover>();
       
        
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "jumpAble":
                _player.isGrounded = true;
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
                

                //teleports player back to issland instead of reloading scene

                //_gamMaster.Playcrowd();
                //_player.rb.velocity = Vector3.zero;
               // transform.position = new Vector3(0.769f, 60.76f, -225.21f);
                break;

            case "Win":
                AudioSource.PlayClipAtPoint(_clipyay, Camera.main.transform.position);
                
                break;
        }
    }

    IEnumerator LoadFirstLevel()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("World1");
    }

    private void WonGame()
    {
        
    }

}
