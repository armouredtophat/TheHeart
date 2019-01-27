using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
    //Script for controlling the player. 

    //Player Components to use and call on. Transform, collider, and ridgidbody. 
    public Transform Player;
    public BoxCollider2D Mycollidor;
    public Rigidbody2D RigidBodyChar;
    public float heading;
    public int Health = 100;
    public Text DisplayHealth;
    public Image HealthHeart;
    public Sprite[] Bubbles;
    public Animator MovementDetect;

    //floats for buttons and rotations as well as movement speed. 
    public float speed;
    private float buttonX;
    private float buttonY;
    public string DeadScene;

    // Update is called once per frame
    void Update(){
     
        buttonX = Input.GetAxis("Horizontal");
        buttonY = Input.GetAxis("Vertical");    

        MovementDetect.SetFloat("HMove", buttonX);
        MovementDetect.SetFloat("VMove", buttonY);

        if(buttonX != 0){
        float heading = Mathf.Atan2(-buttonX,buttonY);
        transform.rotation = Quaternion.Euler(0f,0f,heading*Mathf.Rad2Deg);
    }
    	if(buttonY != 0){
        float heading = Mathf.Atan2(-buttonX,buttonY);
        transform.rotation = Quaternion.Euler(0f,0f,heading*Mathf.Rad2Deg);

    }
    	if( Health == 90){
    		HealthHeart.sprite = Bubbles[1];
    	}
    	if( Health == 80){
    		HealthHeart.sprite = Bubbles[2];
    	}
    	if( Health == 70){
    		HealthHeart.sprite = Bubbles[3];
    	}
    	if( Health == 60){
    		HealthHeart.sprite = Bubbles[4];
    	}
    	if( Health == 50){
    		HealthHeart.sprite = Bubbles[5];
    	}
    	if( Health == 40){
    		HealthHeart.sprite = Bubbles[6];
    	}
    	if( Health == 30){
    		HealthHeart.sprite = Bubbles[7];
    	}
    	if( Health == 20){
    		HealthHeart.sprite = Bubbles[8];
    	}
    	if( Health == 10){
    		HealthHeart.sprite = Bubbles[9];
    	}
    	if( Health == 0){
    		Dead();
    	}



    DisplayHealth.text = Health.ToString();
}


    void FixedUpdate(){
		//Setting the velocity and controlling the speed. 
        RigidBodyChar.velocity = new Vector3(buttonX * speed, RigidBodyChar.velocity.y, 0f);
        RigidBodyChar.velocity = new Vector3(RigidBodyChar.velocity.x, buttonY * speed, 0f);
    }

    void OnCollisionEnter2D(Collision2D col){
    	if (col.gameObject.tag == "Enemy")
        {
            Health = Health - 10;
        }
    }
    
    public void Dead(){
    	SceneManager.LoadScene(DeadScene);
    }
}