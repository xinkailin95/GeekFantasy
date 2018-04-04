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
				collision.gameObject.transform.position = new Vector3 (436, -90);
				Player._instance.Finish ();
				UIManager._instance.AddScore ();
			
			}
			break;
		case"Enemy1":
			Enemy._instance.enemyLife [1, 1] = Enemy._instance.enemyLife [1, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [1, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy2":
			Enemy._instance.enemyLife [2, 1] = Enemy._instance.enemyLife [2, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [2, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy3":
			Enemy._instance.enemyLife [3, 1] = Enemy._instance.enemyLife [3, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [3, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy4":
			Enemy._instance.enemyLife [4, 1] = Enemy._instance.enemyLife [4, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [4, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy5":
			Enemy._instance.enemyLife [5, 1] = Enemy._instance.enemyLife [5, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [5, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy6":
			Enemy._instance.enemyLife [6, 1] = Enemy._instance.enemyLife [6, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [6, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy7":
			Enemy._instance.enemyLife [7, 1] = Enemy._instance.enemyLife [7, 1] - UIManager._instance.attackPower;
			;
			if (Enemy._instance.enemyLife [7, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy8":
			Enemy._instance.enemyLife [8, 1] = Enemy._instance.enemyLife [8, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [8, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy9":
			Enemy._instance.enemyLife [9, 1] = Enemy._instance.enemyLife [9, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [9, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy10":
			Enemy._instance.enemyLife [10, 1] = Enemy._instance.enemyLife [10, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [10, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy11":
			Enemy._instance.enemyLife [11, 1] = Enemy._instance.enemyLife [11, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [11, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy12":
			Enemy._instance.enemyLife [12, 1] = Enemy._instance.enemyLife [12, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [12, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy13":
			Enemy._instance.enemyLife [13, 1] = Enemy._instance.enemyLife [13, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [13, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy14":
			Enemy._instance.enemyLife [14, 1] = Enemy._instance.enemyLife [14, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [14, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy15":
			Enemy._instance.enemyLife [15, 1] = Enemy._instance.enemyLife [15, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [15, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Enemy16":
			Enemy._instance.enemyLife [16, 1] = Enemy._instance.enemyLife [16, 1] - UIManager._instance.attackPower;
			if (Enemy._instance.enemyLife [16, 1] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();

			}
			break;
		case"Building":
			
			break;
		case"Bonus":
			Destroy (collision.gameObject);
			break;
		default:
                string hit_obj = collision.gameObject.GetComponentInParent<Transform>().name;
            if (hit_obj == "room11" || hit_obj == "born" || hit_obj == "cafe" || hit_obj == "library" || hit_obj == "bossmap" || hit_obj == "double"|| hit_obj == "NSC")
                Destroy (gameObject);
			break;
		}
	}
}
