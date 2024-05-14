using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour
{	
	void PlayCantPlayLevelWarning() 
	{
		print("error:::");
	}
	
	public void LoadLevel(int levelIndex)
	{
		//get the reached level index
		int reachedLevel = PlayerPrefs.GetInt("LevelIndex", 1);
		
		if (reachedLevel < levelIndex)
		 	PlayCantPlayLevelWarning();
			return;

		SceneManager.LoadScene("Level " + levelIndex);
	}
	
	public void LoadReachedLevel()
	{
		//get the reached level index
		int reachedLevel = PlayerPrefs.GetInt("LevelIndex", 1);
		
		SceneManager.LoadScene("Level " + reachedLevel);
	}
}
