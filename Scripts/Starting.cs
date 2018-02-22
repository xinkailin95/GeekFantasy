using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Starting : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
		Button btn = this.GetComponent<Button> ();
		btn.onClick.AddListener (OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnClick(){
		SceneManager.LoadScene (1);
	}

}

