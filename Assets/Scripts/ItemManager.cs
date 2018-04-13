using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public GameObject[] items;
	public bool[] isExist= new bool[10];


	public static ItemManager _instance;
	// Use this for initialization

	private void Awake(){
		_instance = this;
	}

	void Start () {
		
		for (int i = 0; i < items.Length; i++) {
			isExist [i] = true;
		}
	}

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == null) {
				isExist [i] = false; 
			}
		}

	}
}
