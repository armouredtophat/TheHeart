using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    //Script for controlling the player. 

    //Player Components to use and call on. Transform, collider, and ridgidbody. 
    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;

    //floats for buttons and rotations as well as movement speed. 
    public float speed;
    private float buttonX;
    private float buttonY;
    private float Yrotate = 0f;
    private float Xrotate = 0f;

    //private bool escapebool = false;

    //Manager variable to access the manager in the scene.
    //public Manager ThisManager;
    //public WeaponInventory ThisInventory;

    //Animator for the Character controller to access and use. 
    //public Animator animator;

    // Update is called once per frame
    void Update(){

        //Stops the players movement when inside of a panel for crafting. 
       // if(ThisManager.anyMenuOpen){
           // buttonX = 0f;
           // buttonY = 0f;
      //  }
        //Else will let the player move as normal.
       // else{
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");
    //}

        //The players rotate is changing based on when the player is moving left or right. this keeps it updated. 
        //Player.eulerAngles = new Vector3(Xrotate, Yrotate, 0f);
        
        //animator for character
        //animator.SetFloat("Hmove", buttonX);
        //animator.SetFloat("Vmove", buttonY);

        //This sets the rotates. 
        //if (buttonX < 0f){
          // Yrotate = 180f;
        //}
        //if (buttonX > 0f){
           //Yrotate = 0f;
        //}

        //Escape button to open a new panel to exit, or to simply save. 
        //if(Input.GetKeyDown(KeyCode.Escape) && escapebool == false) {
            //escapebool = true;
            //ThisManager.TogglePauseMenu( escapebool );
       // }
       // else if(Input.GetKeyDown(KeyCode.Escape) && escapebool == true){
            //escapebool = false;
           // ThisManager.TogglePauseMenu( escapebool );
       // }
}

    void FixedUpdate(){
		//Setting the velocity and controlling the speed. 
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }


    
}