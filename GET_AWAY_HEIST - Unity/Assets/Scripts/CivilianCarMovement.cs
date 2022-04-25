/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 * 
 * Last Edited by: Betzaida Ortiz Rivas
 * Last Edited: 4/25/2022
 * 
 * Description: Incoming civlian cars controller
****/

/*** Using Namespaces ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SelectionBase] //forces selection of parent object
public class CivilianCarMovement : MonoBehaviour
{
    /*** VARIABLES ***/

    [Header("Civilians Settings")]
    public float speed = 10f;

    private BoundsCheck bndCheck; //reference to bounds check component

    //method that acts as a field (property)
    public Vector3 pos
    {
        get { return (this.transform.position); }
        set { this.transform.position = value; }
    }

    /*** MEHTODS ***/

    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end Awake()


    // Update is called once per frame
    void Update()
    {
        //Call the Move Method

        Move();

        //Check if bounds check exists and the object is off the bottom of the screen
        if (bndCheck != null && bndCheck.offDown)
        {
            Destroy(gameObject); //destory the object

        }//end if(bndCheck != null && !bndCheck.offDown)


    }//end Update()


    //Virtual methods can be overridden by child instances
    public virtual void Move()
    {
        Vector3 temPos = pos; //temporary position
        temPos.z -= speed * Time.deltaTime; //temporary z position, moving forward
        pos = temPos; //position is equal to temporary position

    } // end Move()

}
