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
