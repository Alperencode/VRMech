using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LrTesting : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineRendererScript line;

    private void Start()
    {
        line.setUpLine(points);
    }
}
