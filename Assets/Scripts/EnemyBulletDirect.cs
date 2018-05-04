using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDirect : MonoBehaviour
{

	public float moveSpeed;

	private Vector3 newPosition;
	//private Transform hero;
	private float distance;

	// Use this for initialization


	void Start ()
	{

		moveSpeed = 10f;
		//hero = player.transform;

	}

	// Update is called once per frame
	void Update ()
	{
		
	
		transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		Destroy (gameObject, 6f);
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Player":
			Player._instance.curplayerLife = Player._instance.curplayerLife - 2;
			Destroy (gameObject);
			break;
		case"Building":
			Destroy (gameObject);
			break;
		default:
			break;
		}
	}
}
