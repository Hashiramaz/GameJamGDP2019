﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAreaGizmos : MonoBehaviour
{
    public Color gismoscolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos() {
        
        Gizmos.color = gismoscolor;
        
        Gizmos.DrawCube(transform.position,transform.localScale);

        
    }
}
