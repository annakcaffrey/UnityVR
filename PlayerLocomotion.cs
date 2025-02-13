﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerLocomotion : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward = true;
    public bool moveBack = true;
    private CharacterController cc;
        // Use this for initialization
    void Start()
    {
    cc = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
        moveForward = true;
        }
        else
        {
        moveForward = false;
        }
        if (moveForward )
        {   
        Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
        cc.SimpleMove(forward * speed);
        }


        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x > 90.0f)
        {
        moveBack = true;
        }
        else
        {
        moveBack = false;
        }
        if (moveBack)
        {   
        Vector3 back = vrCamera.TransformDirection(Vector3.back);
        cc.SimpleMove(back * speed);
        }
    
    }
}
