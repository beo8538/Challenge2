using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    /*** VARIABLES ***/
    [Header("Enemy settings")]
    public GameObject[] prefabEnemies; //array of all enemy prefabs
    public float enemySpawnPerSecond; //enemy count to spawn per second
    public float enemyDefaultPadding; //padding positon of each enemy

    private BoundsCheck bndCheck;

    public Transform Player;
    public float MoveSpeed = 4.0f;
    public int MaxDist = 10;
    public int MinDist = 5;

    void Start()
    {
       
    }



    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                
            }
        }
    }
}
