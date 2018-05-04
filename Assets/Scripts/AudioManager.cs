using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager _instance;


	// Use this for initialization
	void Awake ()
	{
		_instance = this;
		DontDestroyOnLoad (transform.gameObject);
	}
	

}
