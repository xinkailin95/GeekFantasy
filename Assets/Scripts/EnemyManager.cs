using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	public GameObject[] enemyGOs;
	public int[] enemyLife = new int[36];
	public bool[] isDead = new bool[36];
	public bool[] hasKey = new bool[7];
	private float distance;
	public GameObject keyPrefab;

	public static EnemyManager _instance;
	// Use this for initialization
	private void Awake ()
	{
		_instance = this;
		for (int i = 1; i < enemyGOs.Length; i++) {
			enemyLife [i] = 10;
			isDead [i] = false;


		}
		for (int i = 0; i < hasKey.Length; i++) {
			hasKey [i] = false;
		}
		enemyLife [0] = 84;

	}

	void Start ()
	{
		

	}

	// Update is called once per frame
	void Update ()
	{
		for (int i = 1; i < enemyGOs.Length; i++) {
			if (enemyLife [i] < 0 && isDead [i] == false) {
				UIManager._instance.AddScore ();
				enemyGOs [i].GetComponent<Enemy> ().transform.position = new Vector3 (439, -90);
				isDead [i] = true;
			} else {

			}

		}

		for (int i = 1; i < enemyGOs.Length; i++) {
			if (enemyLife [1] < 0 && enemyLife [2] < 0 && enemyLife [3] < 0 && enemyLife [16] < 0 && enemyLife [20] < 0 && enemyLife [21] < 0 && hasKey [0] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [0] = true;
			} else if (enemyLife [4] < 0 && enemyLife [5] < 0 && enemyLife [6] < 0 && enemyLife [22] < 0 && hasKey [1] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [1] = true;
			} else if (enemyLife [7] < 0 && enemyLife [10] < 0 && enemyLife [29] < 0 && enemyLife [30] < 0 && hasKey [2] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [2] = true;
			} else if (enemyLife [11] < 0 && enemyLife [12] < 0 && enemyLife [23] < 0 && enemyLife [25] < 0 && hasKey [3] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [3] = true;
			} else if (enemyLife [13] < 0 && enemyLife [14] < 0 && enemyLife [18] < 0 && enemyLife [24] < 0 && enemyLife [33] < 0 && hasKey [4] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [4] = true;
			} else if (enemyLife [15] < 0 && enemyLife [17] < 0 && enemyLife [19] < 0 && enemyLife [31] < 0 && enemyLife [32] < 0 && enemyLife [34] < 0 && enemyLife [35] < 0 && hasKey [5] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [5] = true;
			} else if (enemyLife [28] < 0 && enemyLife [26] < 0 && enemyLife [9] < 0 && enemyLife [8] < 0 && enemyLife [27] < 0 && hasKey [6] == false) {
				Instantiate (keyPrefab, transform.position, Quaternion.Euler (transform.eulerAngles));
				UIManager._instance.addKey ();
				hasKey [6] = true;
			}
		}

	}
}
