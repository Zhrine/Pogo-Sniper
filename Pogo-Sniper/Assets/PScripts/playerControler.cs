using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerControler : MonoBehaviour
{
    public float movement = 0f;
    
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }
    void Update()
    {
        Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
