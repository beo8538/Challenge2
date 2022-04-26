/***
 * Created by: Cristian Misla
 * Created on: 4/00/2022
 * 
 * Edited by:
 * Edited on:
 * 
 * Description: Makes Enemy (cop car) follow player
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed = 4.0f;
    public int MaxDist = 10;
    public int MinDist = 5;

    //public Rigidbody rb;


    void Start()
    {
       // rb.constraints = RigidbodyConstraints.FreezeAll; 
    }

    void LateUpdate()
    {
        transform.LookAt(Player); //Makes Enemy target the player

        if (Vector3.Distance(transform.position, Player.position) >= MinDist) //if the distance of the player and enemy is greater than the MinDist then...
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime; //move the enemy towards the player

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist) //if the distance of the player and the enemy is less than the MaxDist then...
            {
                
            }
        }
    }
}
