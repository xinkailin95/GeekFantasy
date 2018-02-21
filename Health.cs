using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public int characterMaxHP;
	public int characterCurrentHP;

	// Use this for initialization
	void Start () {
		characterCurrentHP = characterMaxHP;

	}
	
	// Update is called once per frame
	void Update () {
		if (characterCurrentHP <= 0) {
			gameObject.SetActive (false);
			
		}
	}
	public void Hurt(int damage)
	{
		characterCurrentHP = characterCurrentHP - damage;
	}
	public void setMaxHP()
	{
		characterCurrentHP = characterMaxHP;
	}
}
