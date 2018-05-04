using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public float moveSpeed = 3f;

	private Vector3 origin;
	private Vector3 newPos;

	private void Start ()
	{
		origin = new Vector3 (Player._instance.transform.position.x, Player._instance.transform.position.y + 4f);
		newPos = new Vector3 (origin.x, origin.y + 3f);
	}

	void Update ()
	{
		transform.position = Vector3.MoveTowards (origin, newPos, moveSpeed * Time.deltaTime);
		Destroy (gameObject, 3f);
	}

}
