﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 gravity;
        
    public void Start()
    {

    }
    public void Update()
    {

        var position = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(position * speed.x, gravity.y, 0) * Time.deltaTime;

        if (transform.position.y <= -1.5f)
        {
            transform.position = transform.position + new Vector3(0, -gravity.y, 0) * Time.deltaTime;
        }
        if (Input.GetButtonDown("Jump") && transform.position.y <= -1f)
        {
            transform.position = transform.position + new Vector3(0, speed.y, 0) * Time.deltaTime;
        }
        Debug.Log(Time.deltaTime);


    }

}





