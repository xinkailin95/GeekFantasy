using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{

	public Transform warpTarget;
	//public AudioSource changeScene;
	void OnTriggerEnter2D (Collider2D other)
	{

		// Debug.Log ("An object.");
		if (other.gameObject.name == "Player")
			other.gameObject.transform.position = warpTarget.position;
			//changeScene.Play ();
	}

}
