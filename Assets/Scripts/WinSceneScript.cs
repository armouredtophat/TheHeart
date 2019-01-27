using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour
{
    public string LevelToLoad;

    public void OnCollisionEnter2D(Collision2D col){
    	if (col.gameObject.tag == "Player")
        {
           SceneManager.LoadScene(LevelToLoad);
        }

    	
}
}
