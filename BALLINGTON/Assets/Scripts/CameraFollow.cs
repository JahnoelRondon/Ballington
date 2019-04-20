using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0, 1.5f, -4f);
    [SerializeField] float smoothspd = 0.125f;


    void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + offset;
        
        transform.position = desiredPosition;
        transform.LookAt(target);

        
    }


}
