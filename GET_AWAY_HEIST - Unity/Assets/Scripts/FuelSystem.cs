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


    

    // Start is called before the first frame update
    void Start()
    {
        mpg = baseInterval;
        isCarMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isCarMoving)
        {
            if(mpg > 0)
            {
                mpg -= Time.deltaTime;
            }
            else
            {
                mpg = baseInterval;
                currentFule -= 1f;
            }
            
        }


        fuelDisplay.text = "Fuel: " + currentFule;
    }
}
