/***
 * Created by: Betzaida Ortiz Rivas
 * Created on: 4/20/2022
 * 
 * Edited by:
 * Edited on: 4/22/2022
 * 
 * Description: goes through the cars that the player has
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelection : MonoBehaviour
{
    private int currCar;
    private void selectCar(int index)
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    public void changeCar(int change)
    {
        currCar += change;
        selectCar(currCar);
    }
}
