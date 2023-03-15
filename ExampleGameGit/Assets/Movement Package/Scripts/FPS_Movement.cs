using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* TASK: Comment on the code as we go through it
* Here we are doing Movement and Jumping
* Manipulate this script to add in a Jump function
* Extra Task: Add in Crouch or Sprint functions (or both)
*/

public class FPS_Movement : MonoBehaviour
{
    public float walkSpeed; //What's this for?
    public float jumpHeight; //What's this for?
    private float gravity = -9.81f; //What's this for?
    private CharacterController controller; //What's this for?
    private Vector3 velocity; //What's this for?
    private Vector3 moveDirection; //What's this for?

    void Start()
    {
        controller = GetComponent<CharacterController>(); //What's this for?
    }
    
    void FixedUpdate()
    {
        Walking(); //Why do we use fixed update for this?
    }  

    void Walking()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); //What's this for?
        float moveVertical = Input.GetAxisRaw("Vertical");   //What's this for?
        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward); //What's this for?
        controller.Move(moveDirection * walkSpeed * Time.deltaTime);  //What's this for?  
        velocity.y += gravity * Time.deltaTime; //What's this for?
        controller.Move(velocity * Time.deltaTime); //What's this for?
    }

}
