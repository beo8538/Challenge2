using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGen : MonoBehaviour
{
    public GameObject[] RoadPieces = new GameObject[2];
    const float RoadLength = 100f; //length of roads

    const float RoadSpeed = 5f; //speed to scroll roads at
    public void Update()
    {
        foreach (GameObject road in RoadPieces)
        {
            Vector3 newRoadPos = road.transform.position;
            newRoadPos.z -= RoadSpeed * Time.deltaTime;
            if (newRoadPos.z < -RoadLength / 2)
            {
                newRoadPos.z += RoadLength;
            }
            road.transform.position = newRoadPos;
        }
    }
}
