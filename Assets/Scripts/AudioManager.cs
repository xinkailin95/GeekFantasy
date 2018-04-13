using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		DontDestroyOnLoad (transform.gameObject);
	}
	

}
