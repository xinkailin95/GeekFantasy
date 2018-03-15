using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float moveSpeed = 10;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.up * moveSpeed * Time.deltaTime, Space.World);
		Destroy (gameObject, 0.15f);

	}
	private void OnTriggerEnter2D(Collider2D collision){

		switch (collision.tag) 
		{
		case"Enemy":
			Enemy._instance.enemyLife = Enemy._instance.enemyLife - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy1":
			Enemy1._instance1.enemyLife1 = Enemy1._instance1.enemyLife1 - UIManager._instance.attackPower;
			if (Enemy1._instance1.enemyLife1 < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy2":
			Enemy2._instance2.enemyLife2 = Enemy2._instance2.enemyLife2 - UIManager._instance.attackPower;
			if (Enemy2._instance2.enemyLife2 < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy3":
			Enemy3._instance3.enemyLife3 = Enemy3._instance3.enemyLife3 - UIManager._instance.attackPower;
			if (Enemy3._instance3.enemyLife3 < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy4":
			Enemy4._instance4.enemyLife4 = Enemy4._instance4.enemyLife4 - UIManager._instance.attackPower;;
			if (Enemy4._instance4.enemyLife4 < 0) {
				Destroy (collision.gameObject);
				UIManager._instance.AddScore ();
			}
			break;
		case"Building":
			
			break;
		default:
			break;
		}
	}
}
