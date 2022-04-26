/**** 
 * Created by: Yao Wang
 * Date Created: 4/25/2022
 * 
 * Last Edited by: Yao Wang
 * Last Edited: 4/25/2022
 * 
 * Description: Health System 
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float health = 100f;
    public Text healthDisplay;
    public float damage = 10f;

    GameManager gm; //gaem manager

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "Health: " + health; //display the health level 

    }

    void HitByPolice(Collider onCollision) //to check car hit by the cars
    {
        if (onCollision.gameObject.tag == "Enemy") //if hit by police
        {
            health = 0;
            Debug.Log("Game Over");
            gm.GameOver(); //load end scene 
        }

        if(onCollision.gameObject.tag == "CivilianCar") //hit by CivilianCars
        {
            health -= 20f;
            Debug.Log("Game Over" + health);
        }

        
    }
}
