using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
	public float speed = 10;
	public float rotationSpeed = 4;
	public float highSpeed = 2;

	public Rigidbody2D carRb;
	public Rigidbody2D wheelBackRb;
	public Rigidbody2D wheelFrontRb;
	public GroundCheck groundCheck;
	public UiPlayerController uiPlayerController;

	void FixedUpdate()
	{
		RotateWheels();
		if (!groundCheck.isGrounded)
		{
			RotateCar();
		}
	}

	void RotateCar()
	{
		float h = uiPlayerController.h * rotationSpeed * Time.fixedDeltaTime * 50;
		carRb.MoveRotation(carRb.rotation + h);
	}

	void RotateWheels()
	{
		float h = -uiPlayerController.h * speed * Time.fixedDeltaTime * 100;

		if (groundCheck.highSpeed) h *= highSpeed;

		wheelBackRb.MoveRotation(wheelBackRb.rotation + h);
		wheelFrontRb.MoveRotation(wheelFrontRb.rotation + h);
	}
}