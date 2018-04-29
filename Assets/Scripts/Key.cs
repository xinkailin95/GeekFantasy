using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public float moveSpeed = 0.07f;

	private Vector3 origin;

	private void Start(){
		origin = new Vector3 (Player._instance.transform.position.x, Player._instance.transform.position.y + 4f);
	}
	void Update ()
	{
		transform.position = Vector3.MoveTowards (origin, new Vector3 (transform.position.x, transform.position.y + 3f, 0), moveSpeed);
		Destroy (gameObject, 3f);
	}

}
