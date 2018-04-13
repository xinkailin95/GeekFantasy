using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{

	public Transform warpTarget;

	IEnumerator OnTriggerEnter2D (Collider2D other)
	{
		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();

		// Debug.Log ("An object.");
		if (other.gameObject.name == "Player") {
			
			yield return StartCoroutine (sf.FadeToBlack ());

			other.gameObject.transform.position = warpTarget.position;

			yield return StartCoroutine (sf.FadeToClear ());
		}

	}

}
