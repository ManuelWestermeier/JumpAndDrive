using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonPoint : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag != "Ignore" && other.gameObject.tag != "Player") return;
		//get the current level index
		int reachedLevel = PlayerPrefs.GetInt("LevelIndex", 1);
		//get the scene index
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		//add to the sceneIndex 1
		sceneIndex++;
		//check if the next scene isnt saved as reached level index
		if (reachedLevel < sceneIndex)
			//set the level index
			PlayerPrefs.SetInt("LevelIndex", sceneIndex);
		//load next Level
		SceneManager.LoadScene("Level " + sceneIndex);
	}
}
