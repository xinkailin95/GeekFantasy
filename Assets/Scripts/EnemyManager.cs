using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
	public GameObject[] enemyGOs;
	public int[] enemyLife = new int[16];
	public bool[] isDead = new bool[16];
	private float distance; 

	public static EnemyManager _instance;	
	// Use this for initialization
	private void Awake(){
		_instance = this;
        for (int i = 1; i < enemyGOs.Length; i++)
        {
            enemyLife[i] = 10;
            isDead[i] = false;

        }
        enemyLife[0] = 84;

    }
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {
		for (int i = 1; i < enemyGOs.Length; i++) {
			if (enemyLife [i] < 0 && isDead [i] == false) {
				UIManager._instance.AddScore ();

				enemyGOs [i].GetComponent<Enemy> ().transform.position = new Vector3 (439, -90);
				isDead [i] = true;
			} else {

			}

		}
	}
}
