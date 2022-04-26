/***
 * Created by: Yao
 * Created on: 4/19/2022
 * 
 * Edited by:
 * Edited on: 4/24/2022
 * 
 * Description: Spawns Enemies (civilian cars) that player must avoid
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthSystem1 : MonoBehaviour
{
    GameManager gm;
    /***void HitByPolice(Collider onCollision) //to check car hit by the cars
    {
        if (onCollision.gameObject.tag == "Enemy") //if hit by police
        {
            Debug.Log("Game Over");
            gm.GameOver(); //load end scene 
        }

        if (onCollision.gameObject.tag == "CivilianCar") //hit by CivilianCars
        {
            Debug.Log("Game Over");
            gm.GameOver(); //load end scene 
        }
    }***/

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("End Scene");
        }
        if (other.gameObject.tag == "CivilianCars")
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("End Scene");
        }



    }

}
