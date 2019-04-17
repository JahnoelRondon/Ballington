using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderHandler : MonoBehaviour
{
    private PlayerMover _player;

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
            case "Death":
                SceneManager.LoadScene("World1");
                //_player.rb.velocity = Vector3.zero;
                //transform.position = new Vector3(0f, 20f, 0f);
                break;
        }
    }
}
