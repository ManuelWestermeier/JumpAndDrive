using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
	public float speed = 10;
	public float rotationSpeed = 4;
	public Rigidbody2D carRb;
	public Rigidbody2D wheelBackRb;
	public Rigidbody2D wheelFrontRb;
	public GroundCheck groundCheck;
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
		carRb.MoveRotation(carRb.rotation + Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime * 50);
	}

	void RotateWheels()
	{
		float h = -Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime * 100;
		wheelBackRb.MoveRotation(wheelBackRb.rotation + h);
		wheelFrontRb.MoveRotation(wheelFrontRb.rotation + h);
	}
}