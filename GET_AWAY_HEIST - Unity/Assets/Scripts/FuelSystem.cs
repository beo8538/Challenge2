/**** 
 * Created by: Yao Wang
 * Date Created: 4/25/2022
 * 
 * Last Edited by: Yao Wang
 * Last Edited: 4/25/2022
 * 
 * Description: Fuel system for player's car
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSystem : MonoBehaviour
{
   

    public float currentFule = 100f;
    public Text fuelDisplay;
    bool isCarMoving;
    public float mpg = 1f;
    public float baseInterval;
    public float fuelTankVolume = 10;

    basicmovement basicMovement; //call class basic movemnet
    private BoundsCheck bc; //reference to the bounds check component


    // Start is called before the first frame update
    void Start()
    {
      
        mpg = baseInterval;
        isCarMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isCarMoving) //check that is car moving 
        {
            if(mpg > 0) //get mpg
            {
                mpg -= Time.deltaTime; 
            }
            else
            {
                mpg = baseInterval;
                currentFule -= 1f;
            }

            if(Input.GetKeyDown(KeyCode.LeftShift)) //press shift deduce fule
            {
                currentFule -= 10f; //fuel - 10 

            }

            if (currentFule == 0) //if no duel car stop 
            {
                basicMovement.carStop(); //call method form basicMovement 
            }
            
            if (currentFule > 100) //if fule over 100. keep the fuel to 100f. 
            {
                currentFule = 100;
            }



        }


        fuelDisplay.text = "Fuel: " + currentFule; //diaplay the fuel level
    }

    void OnTriggerEnter(Collider gasTank)
    {
        if(gasTank.gameObject.tag == "Gas_Can") //if hit the fuel tank, add 10 fuel to tank
        {
            currentFule = currentFule + fuelTankVolume;
            
            
            
        }
    }

    
}
