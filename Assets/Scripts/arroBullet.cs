using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arroBullet : MonoBehaviour
{

	public float moveSpeed = 10;
	public float rate;

	// Use this for initialization

	void Start ()
	{
		rate = transform.localScale.y;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		rate = rate + 0.1f;
		transform.localScale = new Vector3 (0.08678f, rate, 1);
		transform.Translate (transform.up * moveSpeed * Time.deltaTime * 7.5f, Space.World);
		Destroy (gameObject, 0.14f);

	}

	private void OnTriggerEnter2D (Collider2D collision)
	{

		switch (collision.tag) {
		case"Enemy":
			EnemyManager._instance.enemyLife [0] = EnemyManager._instance.enemyLife [0] - UIManager._instance.attackPower_R;
			if (EnemyManager._instance.enemyLife [0] < 0) {
				collision.gameObject.transform.position = new Vector3 (436, -90);
				UIManager._instance.AddScore ();
			}
			break;
		case"Enemy1":
			EnemyManager._instance.enemyLife [1] = EnemyManager._instance.enemyLife [1] - UIManager._instance.attackPower_R;

			break;
		case"Enemy2":
			EnemyManager._instance.enemyLife [2] = EnemyManager._instance.enemyLife [2] - UIManager._instance.attackPower_R;

			break;
		case"Enemy3":
			EnemyManager._instance.enemyLife [3] = EnemyManager._instance.enemyLife [3] - UIManager._instance.attackPower_R;

			break;
		case"Enemy4":
			EnemyManager._instance.enemyLife [4] = EnemyManager._instance.enemyLife [4] - UIManager._instance.attackPower_R;

			break;
		case"Enemy5":
			EnemyManager._instance.enemyLife [5] = EnemyManager._instance.enemyLife [5] - UIManager._instance.attackPower_R;

			break;
		case"Enemy6":
			EnemyManager._instance.enemyLife [6] = EnemyManager._instance.enemyLife [6] - UIManager._instance.attackPower_R;

			break;
		case"Enemy7":
			EnemyManager._instance.enemyLife [7] = EnemyManager._instance.enemyLife [7] - UIManager._instance.attackPower_R;

			break;
		case"Enemy8":
			EnemyManager._instance.enemyLife [8] = EnemyManager._instance.enemyLife [8] - UIManager._instance.attackPower_R;

			break;
		case"Enemy9":
			EnemyManager._instance.enemyLife [9] = EnemyManager._instance.enemyLife [9] - UIManager._instance.attackPower_R;

			break;
		case"Enemy10":
			EnemyManager._instance.enemyLife [10] = EnemyManager._instance.enemyLife [10] - UIManager._instance.attackPower_R;

			break;
		case"Enemy11":
			EnemyManager._instance.enemyLife [11] = EnemyManager._instance.enemyLife [11] - UIManager._instance.attackPower_R;

			break;
		case"Enemy12":
			EnemyManager._instance.enemyLife [12] = EnemyManager._instance.enemyLife [12] - UIManager._instance.attackPower_R;

			break;
		case"Enemy13":
			EnemyManager._instance.enemyLife [13] = EnemyManager._instance.enemyLife [13] - UIManager._instance.attackPower_R;

			break;
		case"Enemy14":
			EnemyManager._instance.enemyLife [14] = EnemyManager._instance.enemyLife [14] - UIManager._instance.attackPower_R;

			break;
		case"Enemy15":
			EnemyManager._instance.enemyLife [15] = EnemyManager._instance.enemyLife [15] - UIManager._instance.attackPower_R;

			break;
		case"Enemy16":
			EnemyManager._instance.enemyLife [16] = EnemyManager._instance.enemyLife [16] - UIManager._instance.attackPower_R;

			break;
		case"Enemy17":
			EnemyManager._instance.enemyLife [17] = EnemyManager._instance.enemyLife [17] - UIManager._instance.attackPower_R;

			break;
		case"Enemy18":
			EnemyManager._instance.enemyLife [18] = EnemyManager._instance.enemyLife [18] - UIManager._instance.attackPower_R;

			break;
		case"Enemy19":
			EnemyManager._instance.enemyLife [19] = EnemyManager._instance.enemyLife [19] - UIManager._instance.attackPower_R;

			break;
		case"Enemy20":
			EnemyManager._instance.enemyLife [20] = EnemyManager._instance.enemyLife [20] - UIManager._instance.attackPower_R;

			break;
		case"Enemy21":
			EnemyManager._instance.enemyLife [21] = EnemyManager._instance.enemyLife [21] - UIManager._instance.attackPower_R;

			break;
		case"Enemy22":
			EnemyManager._instance.enemyLife [22] = EnemyManager._instance.enemyLife [22] - UIManager._instance.attackPower_R;

			break;
		case"Enemy23":
			EnemyManager._instance.enemyLife [23] = EnemyManager._instance.enemyLife [23] - UIManager._instance.attackPower_R;

			break;
		case"Enemy24":
			EnemyManager._instance.enemyLife [24] = EnemyManager._instance.enemyLife [24] - UIManager._instance.attackPower_R;

			break;
		case"Enemy25":
			EnemyManager._instance.enemyLife [25] = EnemyManager._instance.enemyLife [25] - UIManager._instance.attackPower_R;

			break;
		case"Enemy26":
			EnemyManager._instance.enemyLife [26] = EnemyManager._instance.enemyLife [26] - UIManager._instance.attackPower_R;

			break;
		case"Enemy27":
			EnemyManager._instance.enemyLife [27] = EnemyManager._instance.enemyLife [27] - UIManager._instance.attackPower_R;

			break;
		case"Enemy28":
			EnemyManager._instance.enemyLife [28] = EnemyManager._instance.enemyLife [28] - UIManager._instance.attackPower_R;

			break;
		case"Enemy29":
			EnemyManager._instance.enemyLife [29] = EnemyManager._instance.enemyLife [29] - UIManager._instance.attackPower_R;

			break;
		case"Enemy30":
			EnemyManager._instance.enemyLife [30] = EnemyManager._instance.enemyLife [30] - UIManager._instance.attackPower_R;

			break;
		case"Enemy31":
			EnemyManager._instance.enemyLife [31] = EnemyManager._instance.enemyLife [31] - UIManager._instance.attackPower_R;

			break;
		case"Enemy32":
			EnemyManager._instance.enemyLife [32] = EnemyManager._instance.enemyLife [32] - UIManager._instance.attackPower_R;

			break;
		case"Enemy33":
			EnemyManager._instance.enemyLife [33] = EnemyManager._instance.enemyLife [33] - UIManager._instance.attackPower_R;

			break;
		case"Enemy34":
			EnemyManager._instance.enemyLife [34] = EnemyManager._instance.enemyLife [34] - UIManager._instance.attackPower_R;

			break;
		case"Enemy35":
			EnemyManager._instance.enemyLife [35] = EnemyManager._instance.enemyLife [35] - UIManager._instance.attackPower_R;

			break;

		//case"Building":
		//	Destroy (gameObject);
		//	break;

		default:
			break;
		}
	}
}
