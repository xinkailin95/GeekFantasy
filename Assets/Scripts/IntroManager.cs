using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class IntroManager : MonoBehaviour {

	public bool intro = true;

	public GameObject PanelGo;


	private void Intro(){
		intro = true;
		PanelGo.SetActive (true);
		Time.timeScale = 0;
	}
	private void UnIntro(){
		intro = false;
		PanelGo.SetActive (false);
		Time.timeScale = 1;

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Intro ();
		}

	}
	public void CloseIntro(){
		UnIntro ();
	}
	public void ViewIntro(){
		Intro ();
	}
	public void Starting(){
		SceneManager.LoadScene (1);
	}
}
