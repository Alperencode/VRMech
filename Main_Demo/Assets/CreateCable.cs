using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCable : MonoBehaviour
{
    public GameObject cablePrefab;
    
    public void CreateCables()
    {
        Instantiate(cablePrefab);
    }
}
