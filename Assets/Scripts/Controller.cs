﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    //Script for controlling the player. 

    //Player Components to use and call on. Transform, collider, and ridgidbody. 
    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;
    public float heading;

    //floats for buttons and rotations as well as movement speed. 
    public float speed;
    private float buttonX;
    private float buttonY;

    // Update is called once per frame
    void Update(){
     
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");    

        if(buttonX != 0){
        float heading = Mathf.Atan2(-buttonX,buttonY);
        transform.rotation = Quaternion.Euler(0f,0f,heading*Mathf.Rad2Deg);
    }
    	if(buttonY != 0){
        float heading = Mathf.Atan2(-buttonX,buttonY);
        transform.rotation = Quaternion.Euler(0f,0f,heading*Mathf.Rad2Deg);
    }
}


    void FixedUpdate(){
		//Setting the velocity and controlling the speed. 
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }


    
}