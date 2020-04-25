using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    public CharacterController controller;

    // Speed of the movement
    public float speed = 12f;
    

    // Gravity Setup
    Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpHeight =3f;

    //Variables to check ground colliding (necessary to stop the velocity due to gravity)
    public Transform groundCheck; //this is an object inside our player
    public float groundDistance=0.4f; //radius of the ckeck
    public LayerMask groundMask;

    // if we touch the ground or not
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //check here
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        
        if (isGrounded && velocity.y<0) //if the velocity continiues to pull our player down while its on the ground
        {
             velocity.y = 1f; //reseting the velocity to 0 (theoriquement mais -2 pour des raison doptimisation)
        }
        // Capture
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //jumping before applying the velocity
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //add velocity to the player for the jump effect
            velocity.y = Mathf.Sqrt(jumpHeight* -2f *gravity); //formule
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}
