using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Born : MonoBehaviour {

	public GameObject playerPrefeb;

	public GameObject[] enemyListPrefab;
	//public bool creatPlayer;


	// Use this for initialization
	void Start () {
		if (Input.GetMouseButtonDown (0)) {
			Invoke ("BornPlayer", 0.8f);
		}
	}

	// Update is called once per frame
	void Update () {

	}
	public void BornPlayer(){
		//if(creatPlayer){
			Instantiate (playerPrefeb, transform.position, Quaternion.identity);
		//}
//		else{
//			int num = Random.Range (0, 2);
//			Instantiate (enemyListPrefab[num], transform.position, Quaternion.identity);
//		}
	}
}
