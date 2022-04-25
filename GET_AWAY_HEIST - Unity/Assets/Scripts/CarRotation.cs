/***
 * Created by: Betzaida Ortiz Rivas
 * Created on: 4/19/2022
 * 
 * Edited by:
 * Edited on: 4/24/2022
 * 
 * Description: This rotates car in selection screen
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotation : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation; //rotation for the car
    [SerializeField]
    private float speed; //speed that the rotation is going at

    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime); //manages the speed that the object is rotating
    }
}
