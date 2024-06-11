using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CnavasController : MonoBehaviour
{
	public bool useControlls = false;
	public GameObject mobileControlls;
	public Text buttonText;

	void UpdateState()
	{
		mobileControlls.SetActive(useControlls);
		buttonText.text = useControlls ? "Desktop" : "Mobil";
	}

	void Start()
	{
		useControlls = PlayerPrefs.GetInt("use-controlls", 0) == 1;
		UpdateState();
	}

	public void ToggleControlls()
	{
		useControlls = !useControlls;
		PlayerPrefs.SetInt("use-controlls", useControlls ? 1 : 0);
		UpdateState();
	}
}