using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        
        float health = 1004f;

        float poisonDamage = 125.5f;

        Debug.Log(health);
        while (health > 0)


        {
            
            Debug.Log(health = health - poisonDamage);
            

        }
       
        


        if (health <= 0) // == equal, !=not equal
        {
            Debug.Log("Player has been Unalived!");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
