/***
 * Created by: Betzaida Ortiz Rivas
 * Created on: 4/19/2022
 * 
 * Edited by:
 * Edited on:
 * 
 * Description: This thing should rotate car when mouse is hovering over it?
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotation : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation; //rotation for the car
    private float speed; //speed that the rotation is going at

    public void OnPointerEnter() //maybe switch it back to Update()
    {
        //Output to see if this works
        Debug.Log("Cursor on " + name + " GameObject"); //double check that cursor is on car

        //if()

        transform.Rotate(rotation * speed * Time.deltaTime); //manages the speed that the object is rotating
    }
}
