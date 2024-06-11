using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPlayerController : MonoBehaviour
{
	public float h = 0;
	public bool jump = false;
	bool left = false;
	bool right = false;
	public CnavasController cnavasController;

	void Update()
	{
		if (!cnavasController.useControlls)
		{
			h = Input.GetAxis("Horizontal");
			jump = Input.GetAxisRaw("Vertical") > 0;
			return;
		}
		if ((!left && !right) || (left && right))
		{
			if (h < 0.05 || h > -0.05)
			{
				h = 0;
				return;
			}

			h *= 0.95f;
			return;
		}
		else if (left)
			h = Mathf.Max(-1, h - Time.deltaTime);
		else if (right)
			h = Mathf.Min(1, h + Time.deltaTime);
	}

	public void JumpButton(bool pressed)
	{
		jump = pressed;
	}
	public void LeftButton(bool pressed)
	{
		left = pressed;
	}
	public void RightButton(bool pressed)
	{
		right = pressed;
	}
}
