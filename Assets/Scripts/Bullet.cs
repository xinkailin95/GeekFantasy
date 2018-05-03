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
		Destroy (gameObject, 0.8f);

	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Enemy":
			
			EnemyManager._instance.enemyLife [0] = EnemyManager._instance.enemyLife [0] - UIManager._instance.attackPower;
			if (EnemyManager._instance.enemyLife [0] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				Time.timeScale = 0;
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy1":
			EnemyManager._instance.enemyLife [1] = EnemyManager._instance.enemyLife [1] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy2":
			EnemyManager._instance.enemyLife [2] = EnemyManager._instance.enemyLife [2] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy3":
			EnemyManager._instance.enemyLife [3] = EnemyManager._instance.enemyLife [3] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy4":
			EnemyManager._instance.enemyLife [4] = EnemyManager._instance.enemyLife [4] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy5":
			EnemyManager._instance.enemyLife [5] = EnemyManager._instance.enemyLife [5] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy6":
			EnemyManager._instance.enemyLife [6] = EnemyManager._instance.enemyLife [6] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy7":
			EnemyManager._instance.enemyLife [7] = EnemyManager._instance.enemyLife [7] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy8":
			EnemyManager._instance.enemyLife [8] = EnemyManager._instance.enemyLife [8] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy9":
			EnemyManager._instance.enemyLife [9] = EnemyManager._instance.enemyLife [9] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy10":
			EnemyManager._instance.enemyLife [10] = EnemyManager._instance.enemyLife [10] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy11":
			EnemyManager._instance.enemyLife [11] = EnemyManager._instance.enemyLife [11] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy12":
			EnemyManager._instance.enemyLife [12] = EnemyManager._instance.enemyLife [12] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy13":
			EnemyManager._instance.enemyLife [13] = EnemyManager._instance.enemyLife [13] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy14":
			EnemyManager._instance.enemyLife [14] = EnemyManager._instance.enemyLife [14] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy15":
			EnemyManager._instance.enemyLife [15] = EnemyManager._instance.enemyLife [15] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy16":
			EnemyManager._instance.enemyLife [16] = EnemyManager._instance.enemyLife [16] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy17":
			EnemyManager._instance.enemyLife [17] = EnemyManager._instance.enemyLife [17] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy18":
			EnemyManager._instance.enemyLife [18] = EnemyManager._instance.enemyLife [18] - UIManager._instance.attackPower;
			Destroy (gameObject);
			break;
		case"Enemy19":
			EnemyManager._instance.enemyLife [19] = EnemyManager._instance.enemyLife [19] - UIManager._instance.attackPower;
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
