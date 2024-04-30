using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	bool carIsActive = false;
	bool jumpPlayerIsActive = true;
	public GameObject car;
	public GameObject jumpPlayer;
	public Transform followTarget;
	public ParticleSystem changeParticles;
	public ParticleSystem changeDisabledParticles;
	public CollissionCheckAgainstCarBugs collissionCheckAgainstCarBugs;
	void Update()
	{
		if (Input.GetKeyDown("space"))
			ToggleActivePlayer();

		if (carIsActive)
			followTarget.position = car.transform.position;
		else
			followTarget.position = jumpPlayer.transform.position;
		
		if (followTarget.position.y < -10)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void PlayChnageParticles()
	{
		if (collissionCheckAgainstCarBugs.isColliding && jumpPlayerIsActive)
			changeDisabledParticles.Play();
		else
			changeParticles.Play();
	}

	void ToggleActivePlayer()
	{
		PlayChnageParticles();
		if (!carIsActive)
		{
			if (collissionCheckAgainstCarBugs.isColliding)
			{
				return;
			}
			
			carIsActive = true;
			jumpPlayerIsActive = false;

			car.transform.position = jumpPlayer.transform.position + new Vector3(0, 1, 0);
			car.transform.rotation = jumpPlayer.transform.rotation;
		}
		else
		{
			carIsActive = false;
			jumpPlayerIsActive = true;

			jumpPlayer.transform.position = car.transform.position + new Vector3(0, -1, 0);
		}
		jumpPlayer.SetActive(jumpPlayerIsActive);
		car.SetActive(carIsActive);
	}
}
