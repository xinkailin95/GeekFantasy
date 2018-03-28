using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float moveSpeed = 10;

	// Use this for initialization

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		Destroy (gameObject, 0.23f);

	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Enemy":
			Enemy._instance.enemyLife [0, 1] = Enemy._instance.enemyLife [0, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [0, 1] < 0) {
				Destroy (collision.gameObject);

				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy1":
			Enemy._instance.enemyLife [1, 1] = Enemy._instance.enemyLife [1, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [1, 1] < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy2":
			Enemy._instance.enemyLife [2, 1] = Enemy._instance.enemyLife [2, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [2, 1] < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy3":
			Enemy._instance.enemyLife [3, 1] = Enemy._instance.enemyLife [3, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [3, 1] < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy4":
			Enemy._instance.enemyLife [4, 1] = Enemy._instance.enemyLife [4, 1] - UIManager._instance.attackPower;
			;
			if (Enemy._instance.enemyLife [4, 1] < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Building":
			
			break;
		case"Bonus":
			Destroy (collision.gameObject);
			break;
		default:
			break;
		}
	}
}
