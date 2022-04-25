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
        if (roads != null && roads.Count > 0) //if the road does not equal null and road count is greater than 0
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList(); //sort the list
        } //end if()
    }//end start()

    public void MoveRoad()
    {
        GameObject moveRoad = roads[0]; //sets the game object into the roads list
        roads.Remove(moveRoad); //remove the last prefab on the list
        float newZ = roads[roads.Count - 1].transform.position.z + offset; //set newZ as the road list, remove the last one and move it to the set offset
        moveRoad.transform.position = new Vector3(0, 0, newZ); //position the new free prefab at the set newZ
        roads.Add(moveRoad); //add the new prefab in the list
    } //end MoveRoad()
}
