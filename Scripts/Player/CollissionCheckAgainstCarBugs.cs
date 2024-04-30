using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionCheckAgainstCarBugs : MonoBehaviour
{
	public bool isColliding = false;
	Dictionary<GameObject, bool> collisions = new Dictionary<GameObject, bool>();
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!other.gameObject.CompareTag("DontChangePlayerState")) return;
				
		if (!collisions.ContainsKey(other.gameObject))
		{
			collisions.Add(other.gameObject, true);
		}
		
		isColliding = true;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (!other.gameObject.CompareTag("DontChangePlayerState")) return;
		
		if (collisions.ContainsKey(other.gameObject))
		{
			collisions.Remove(other.gameObject);
		}

		if (collisions.Count == 0)
		{
			isColliding = false;
		}
	}
}