using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererPos : MonoBehaviour
{
    public LineRenderer lineRenderer;

    void Start()
    { 
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, transform.position); 
        lineRenderer.SetPosition(1, new Vector3(0, -1, 2)); 
    }
}

