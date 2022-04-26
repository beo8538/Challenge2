/***
 * Created by: Cristian Misla
 * Created on: 4/00/2022
 * 
 * Edited by:
 * Edited on:
 * 
 * Description: Move player car
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basicmovement : MonoBehaviour
{ //Variables
    public float speed = 15.0F;
    public float speedUp = 30f;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    public SpawnManager spawnManager;
    public FuelSystem GetFuelSystem;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // is the controller on the ground?
        if (controller.isGrounded)
        {
            //theRb.AddForce(transform.forward * forwardAccel * 1000f);
            //rigidbody.addForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") ).normilized * speed);

            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;



            //Jumping
            if (Input.GetButton("Jump"))
                SceneManager.LoadScene("End Scene"); //load the game over scene
                 //moveDirection.y = jumpSpeed;

            if (Input.GetKeyDown(KeyCode.LeftShift)) //speed up
            {
               moveDirection *= speed + speedUp;
               
            }

        }
        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
    }

   

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEnter();
    }

    public void carStop()
    {
       // SetGameState(GameState.GameOver);//set the game state to Game Over

       // SceneManager.LoadScene(gameOverScene); //load the game over scene

    }
}
