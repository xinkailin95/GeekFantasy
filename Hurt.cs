using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour {

	public int damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void theCollision(Collision other)
	{
		if (other.gameObject.name == "Player") 
		{
			other.gameObject.GetComponent<Health> ().Hurt (damage);
		}
	}

}
