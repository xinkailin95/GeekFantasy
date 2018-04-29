using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 1; i < EnemyManager._instance.enemyGOs.Length; i++) {
			if (EnemyManager._instance.enemyLife [1] <= 0 && EnemyManager._instance.enemyLife [2] <= 0 && EnemyManager._instance.enemyLife [3] <= 0) {
				transform.position = new Vector3 (266.9f, 40.8f);
			}

		}

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(gameObject);
		UIManager._instance.keyN = UIManager._instance.keyN + 1;
	}
}
