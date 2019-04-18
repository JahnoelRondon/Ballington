using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerRotation : MonoBehaviour
{
    [SerializeField] float spinSpd = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate (new Vector3(0, 1, 0) * spinSpd * Time.deltaTime);
    }
}
