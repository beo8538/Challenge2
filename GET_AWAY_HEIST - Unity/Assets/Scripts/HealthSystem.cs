using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float health = 100f;
    public Text healthDisplay;
    public float damage = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = "Health: " + health; //display the health level 
    }
    
}
