﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    void Start()
    {
        moveSpeed = -2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,0f,moveSpeed*Time.deltaTime);
    }
}
