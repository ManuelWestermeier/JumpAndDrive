using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	
	public GameObject pauseMenu;
	public GameObject pauseButton;
	
	public void PauseGame() 
	{
		pauseMenu.SetActive(true);
		pauseButton.SetActive(false);
		Time.timeScale = 0;
	}
	
	public void PlayGame() 
	{
		pauseMenu.SetActive(false);
		pauseButton.SetActive(true);
		Time.timeScale = 1;
	}
	
	public void GoToMenu() 
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("HomeScreen");
	}
	 
}
