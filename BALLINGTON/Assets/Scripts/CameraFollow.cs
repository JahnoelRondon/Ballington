using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0, 1.5f, -4f);
    [SerializeField] float smoothspd = 0.125f;

    /*
    public GameObject Player;
    float distance = 10.0f;
    float maxDistance = 12.5f;
    float minDistance = 5.0f;
    private float currentX = 0.0f;
    private float rotationSpeed = 2.0f;
    private float zoomSpeed = 0.2f;
    private Camera mainCamera;
    */

    void Start()
    {
        /*
        Player = GameObject.FindWithTag("Player");
        mainCamera = Camera.main;
        */
    }

    void Update()
    {
        /*
        if (Input.GetMouseButton(2))
        {
            currentX += Input.GetAxis("Mouse X");
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (distance >= minDistance)
                distance -= zoomSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (distance <= maxDistance)
                distance += zoomSpeed;
        }
        */




    }


    void LateUpdate()
    {
        //float _mousex = Input.GetAxis("Mouse X");

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothing = Vector3.Lerp(transform.position, desiredPosition, smoothspd);
        transform.position = smoothing;
        transform.LookAt(target);

        /*
        Vector3 direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(45.0f, currentX * rotationSpeed, mainCamera.transform.position.z);
        mainCamera.transform.position = Player.transform.position + rotation * direction;
        mainCamera.transform.LookAt(Player.transform.position);
        */


    }


}
