using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

	public float moveSpeed = 0.01f;

	private Rigidbody2D r2dE;
	private Vector3 newPosition;
	private Transform hero;
	private GameObject player;

	// Use this for initialization

	void Awake ()
	{
		r2dE = GetComponent<Rigidbody2D> ();

	}

	void Start ()
	{
		
		player = GameObject.FindGameObjectWithTag ("Player");
		hero = player.transform;

	}

	// Update is called once per frame
	void Update ()
	{
		newPosition = Vector3.MoveTowards (transform.position, hero.position, moveSpeed);
		r2dE.MovePosition (newPosition);
		//transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		Destroy (gameObject, 4f);
	}
}
