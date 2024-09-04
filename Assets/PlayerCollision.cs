using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        // Check if the colliding object is the Player
        if (collision.gameObject.name == "Player"|| collision.gameObject.name == "Enemy(Clone)")
        {
            // Destroy the Cube object
            Destroy(gameObject);
        }
    }
}


   