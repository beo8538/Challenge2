using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadGenerator roadGenerator;
    void Start()
    {
        roadGenerator = GetComponent<RoadGenerator>();
    }

    void Update()
    {
        
    }
    public void SpawnTriggerEnter()
    {
        roadGenerator.MoveRoad();
    }
}
