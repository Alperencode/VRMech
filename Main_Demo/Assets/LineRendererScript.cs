using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;

    [SerializeField] public float startWidth;
    [SerializeField] public float endWidth;
    private void Awake()
    {

        lr = GetComponent<LineRenderer>();
    
    }


    public void Start()
    {
        // lr.startColor = Color.red;
        
    }

    public void setUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;

    }

    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
