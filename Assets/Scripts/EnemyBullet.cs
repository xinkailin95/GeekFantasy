using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

	public float moveSpeed;

	private Rigidbody2D r2dE;
	private Vector3 newPosition;
	private Transform hero;
	private GameObject player;
	private float distance;

	// Use this for initialization

	void Awake ()
	{
		r2dE = GetComponent<Rigidbody2D> ();

	}

	void Start ()
	{

		player = GameObject.FindGameObjectWithTag ("Player");
		hero = player.transform;
		moveSpeed = 0.07f;
	}

	// Update is called once per frame
	void Update ()
	{
		newPosition = Vector3.MoveTowards (transform.position, hero.position, moveSpeed);
		r2dE.MovePosition (newPosition);
		//transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		Destroy (gameObject, 6f);
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Player":
			Player._instance.curplayerLife = Player._instance.curplayerLife - 1;

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
