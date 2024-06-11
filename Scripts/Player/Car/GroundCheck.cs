using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public bool isGrounded = false;
	public bool highSpeed = false;
	
	Dictionary<GameObject, bool> collisions = new Dictionary<GameObject, bool>();
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Ignore") || other.CompareTag("DontChangePlayerState")) return;
		
		if (!collisions.ContainsKey(other.gameObject))
		{
			collisions.Add(other.gameObject, true);
		}
		
		if (other.gameObject.tag == "DoubleSpeed")
		{
			highSpeed = true;
		}
		
		isGrounded = true;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Ignore") || other.CompareTag("DontChangePlayerState")) return;
		
		if (collisions.ContainsKey(other.gameObject))
		{
			collisions.Remove(other.gameObject);
		}

		if (other.gameObject.tag == "DoubleSpeed")
		{
			highSpeed = false;
		}
		
		if (collisions.Count == 0)
		{

			isGrounded = false;
		}
	}
}
