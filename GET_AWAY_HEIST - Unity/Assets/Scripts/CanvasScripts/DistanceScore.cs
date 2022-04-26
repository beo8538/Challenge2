/***
 * Created by: Betzaida Ortiz Rivas
 * Created on: 4/19/2022
 * 
 * Edited by:
 * Edited on: 4/24/2022
 * 
 * Description: Spawns Enemies (civilian cars) that player must avoid
***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour
{
    public Transform player; // get position of player
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("Distance: 0"); //how many units we move on Z
    }
}
