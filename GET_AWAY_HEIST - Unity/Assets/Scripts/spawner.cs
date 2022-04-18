using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    /*** VARIABLES ***/
    [Header("Enemy settings")]
    public GameObject[] prefabEnemies; //array of all enemy prefabs
    public float enemySpawnPerSecond; //enemy count to spawn per second
    public float enemyDefaultPadding; //padding positon of each enemy

    private BoundsCheck bndCheck; //reference to the bounds check component

    // Start is called before the first frame update
    void Start()
    {
        bndCheck = GetComponent<BoundsCheck>(); //reference to BoundsCheck component
        Invoke("SpawnEnemy", 1f / enemySpawnPerSecond); //call SpawnEnemy method after time delay

    }//end Start()

    void SpawnEnemy()
    {
        //pcik a random enemy to instantiate
        int idx = Random.Range(0, prefabEnemies.Length);
        /*The Random.Range will never select the max value*/

        GameObject go = Instantiate<GameObject>(prefabEnemies[idx]);

        //Position the enemy above the screen with a random x position
        float enemyPadding = enemyDefaultPadding;

        if (go.GetComponent<BoundsCheck>() != null)
        {
            enemyPadding = Mathf.Abs(go.GetComponent<BoundsCheck>().radius);
        }

        //Set the initial position
        Vector3 pos = Vector3.zero;
        float xMin = -bndCheck.camWidth + enemyPadding;
        float xMax = bndCheck.camWidth - enemyPadding;

        pos.x = Random.Range(xMin, xMax);
        pos.y = bndCheck.camHeight + enemyPadding;

        pos.x = Random.Range(xMin, xMax); //range between the xmin and xmax
        pos.y = bndCheck.camHeight + enemyPadding; // height plus padding, off

        go.transform.position = pos;

        //invoke again
        Invoke("SpawnEnemy", 1f / enemySpawnPerSecond);

    }//end SpawnEnemy()

    // Update is called once per frame
    void Update()
    {

    }
}