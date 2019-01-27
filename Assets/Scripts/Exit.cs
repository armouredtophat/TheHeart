using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

	public string LevelToLoad;
	
	//Quits the game.

    public void doExitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(){
    	SceneManager.LoadScene(LevelToLoad);
    }

}

