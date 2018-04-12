using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour {

	public static NPCManager _instance;

	public GameObject[] NPCManagers;
	public bool[] ifTalked1 = new bool[5];
	// Use this for initialization

	private void Awake(){
		_instance = this;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < NPCManagers.Length; i++) {
			ifTalked1 [i] = NPCManagers [i].GetComponent<NPC> ().ifTalked;
		}
	}
}
