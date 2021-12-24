using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{
    private void Update()
    {
        // Checking if the script working
        Debug.Log("Collision script is active");
    }


    public void OnCollisionEnter(Collision collision)
    {
        // Need to check current game object
        Debug.Log("Collided with " + collision.collider.name);
    }


}
