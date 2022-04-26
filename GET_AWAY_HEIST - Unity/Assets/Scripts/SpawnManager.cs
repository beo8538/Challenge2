/***
 * Created by: Cristian Misla
 * Created on: 4/00/2022
 * 
 * Edited by: Betzaida Ortiz Rivas (added civilian spawner)
 * Edited on: 4/24/2022
 * 
 * Description: From what I can see, this manages the roadGenerator... - Betzaida
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadGenerator roadGenerator; //Reference the generator
    private BoundsCheck bndCheck; //ref to bounds check component
    void Start()
    {
        roadGenerator = GetComponent<RoadGenerator>();
        bndCheck = GetComponent<BoundsCheck>(); //ref to bounds check component

    }
    public void SpawnTriggerEnter()
    {
        roadGenerator.MoveRoad(); //when the player wents the invisible trigger, call the MoveRoad() script

    }//edn SpawnTriggerEnter()

}
