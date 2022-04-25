/***
 * Created by: Cristian Misla
 * Created on: 4/00/2022
 * 
 * Edited by:
 * Edited on:
 * 
 * Description: Generates a continous road on screen
***/

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public List<GameObject> roads;
    private float offset = 40f;

    // Start is called before the first frame update
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveRoad()
    {
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newZ = roads[roads.Count - 1].transform.position.z + offset;
        moveRoad.transform.position = new Vector3(0, 0, newZ);
        roads.Add(moveRoad);
    }
}
