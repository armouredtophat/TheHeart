using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

	public string LevelToLoad;

	public void LoadScene(){
		SceneManager.LoadScene(LevelToLoad);
	}

}
