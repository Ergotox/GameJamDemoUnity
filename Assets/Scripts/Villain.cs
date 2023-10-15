using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    private int health = 100;
    // Start is called before the first frame update
    
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Note"))
        {
            health -= 10;
            print(health);
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
   
}
