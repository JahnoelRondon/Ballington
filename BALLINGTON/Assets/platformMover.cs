using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMover : MonoBehaviour
{
    
    public GameObject _Player;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == _Player)
        {
            _Player.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == _Player)
        {
            _Player.transform.parent = null;
        }
    }
    
}
