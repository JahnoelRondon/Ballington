using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float playerspd = 300f;

    public Rigidbody rb;
    public float jumpForce = 260f;
    public bool isGrounded = false;
    public bool PressedJump = false;
    


    void Start()
    {       
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //pressingjump
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            PressedJump = true;
        }

       
    }


    void FixedUpdate()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = movement * playerspd;

        rb.AddForce(velocity * Time.deltaTime);



        //jumping
        if (PressedJump == true)
        {
            rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            print("pressed space");
            //rb.velocity = new Vector3(rb.velocity.x, jumpForce * Time.deltaTime, rb.velocity.z);

            PressedJump = false;
        }


    }


}
