using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	// Use this for initialization
	AudioSource audio;

	void Awake () 
	{
		DontDestroyOnLoad (transform.gameObject);

	}

	void Start()
	{
		audio = GetComponent<AudioSource>();
	}
	void Update()
	{
		
		if(GameManager.isPaused==true)
			audio.Pause ();
		else if(GameManager.isPaused==false&& !audio.isPlaying)
			audio.Play ();

		
	}


}
