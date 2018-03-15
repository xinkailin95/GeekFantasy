using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public bool isPaused = true;
	public GameObject menuGo;
	public GameObject controlPanel;


	private void Pause(){
		isPaused = true;
		menuGo.SetActive (true);
		Time.timeScale = 0;
	}
	private void UnPause(){
		isPaused = false;
		menuGo.SetActive (false);
		Time.timeScale = 1;

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.Escape)) {
//			Pause ();
//		}

	}
	public void Continue(){
		UnPause ();
	}
	public void Stop(){
		Pause ();
	}

	public void BTS(){
		SceneManager.LoadScene (0);
	}

	private void ViewControl(){
		isPaused = true;
		controlPanel.SetActive (true);
		Time.timeScale = 0;
	}
	private void UnViewControl(){
		isPaused = false;
		controlPanel.SetActive (false);
		Time.timeScale = 1;

	}
	public void VControl(){
		ViewControl ();
	}
	public void UVControl(){
		UnViewControl ();
	}

	public void NewGame(){
		SceneManager.LoadScene (1);
	}

	public void Quit(){
		Application.Quit ();
	}
}
