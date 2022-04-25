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

    basicmovement basicMovement;
    

    // Start is called before the first frame update
    void Start()
    {
        basicMovement = GetComponent<basicmovement>();

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

        }


        fuelDisplay.text = "Fuel: " + currentFule; //diaplay the fuel level
    }
}
