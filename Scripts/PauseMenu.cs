using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	
	public GameObject pauseMenu;
	public GameObject controllUI;
	
	public void PauseGame() 
	{
		pauseMenu.SetActive(true);
		controllUI.SetActive(false);
		Time.timeScale = 0;
	}
	
	public void PlayGame() 
	{
		pauseMenu.SetActive(false);
		controllUI.SetActive(true);
		Time.timeScale = 1;
	}
	
	public void GoToMenu() 
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("HomeScreen");
	}
	 
}
