using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCheck : MonoBehaviour
{

    public GameObject led;

    private void Update()
    {
        // Checking if the script working
        // Debug.Log("Collision script is active");
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "led")
        {
            Debug.Log("LedCheck bool need to be true");
            led.GetComponent<LedScript>().LedCheck = true;

        }
        else if(other.gameObject.name == "PowerCable")
        {
            Debug.Log("PowerCheck bool need to be true");
            led.GetComponent<LedScript>().PowerCheck = true;
        }
    }
}
