using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSticking : MonoBehaviour
{
    //public GameObject _Player;


    /*private void OnCollisionEnter(Collision other)
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
    }*/

    //or 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }

}
