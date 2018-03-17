﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    [SerializeField]
    private float speed = 2.0F;

    [SerializeField]
    private Transform target;


    private void FixedUpdate()
    {
        Vector3 position = target.position;
        position.z = -10.0F;
        position.y =+1F;
        if (position.x <= 0)
        {
            position.x = 0;
        }
        if (position.x >= 50)
        {
            position.x = 50;
        }
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
   
    }
}
