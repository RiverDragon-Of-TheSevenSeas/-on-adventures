using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 

    float horizontalMove = 0f;
    public float speed = 0f;

    public CharacterController2D controller;    
    
    // This script is meant to check player inputs for movement.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        //Movement
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
