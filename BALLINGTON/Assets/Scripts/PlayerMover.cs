using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    //private CharacterController _Controller;

    public float playerspd = 300f;

    public Rigidbody rb;
    public float jumpForce = 1f;
    public bool isGrounded = false;

    void Start()
    {
        //_Controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        PlayerMovement();

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

    }


    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = movement * playerspd;

        rb.AddForce(velocity * Time.deltaTime);
    }



}
