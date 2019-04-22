using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    
    [SerializeField] Transform pos1, pos2;
    [SerializeField] float speed = 5f;
    [SerializeField] Transform startPos;

    Vector3 nextpos;

    void Start()
    {
        nextpos = startPos.position;
    }

    void FixedUpdate()
    {
        if(transform.position == pos1.position) 
        {
            nextpos = pos2.position;
        }

        if(transform.position == pos2.position)
        {
            nextpos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

    }
    
}
