using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public static UIManager _instance;


	public Text levelNum;
	public Text attackPowerNum;


	public int levelN;
	public int scoreN;
	public int attackN;
	public int attackPower;

	private void Awake(){
		_instance = this;

	}
	public void AddScore(){
		scoreN += 1;
	}
	private void AddLevel(){
		if (scoreN < 1) {
			levelN = 1;
			attackPower = 1;
			attackN = 1;
		}
		else if (scoreN >= 1 && scoreN <3) {
			levelN = 2;
			attackPower = 3;
			attackN = 3;
		} 
		else if (scoreN >= 3 && scoreN < 5) {
			levelN = 3;
			attackPower = 5;
			attackN = 5;

		}
		else if(scoreN >= 5){
			levelN = 4;
			attackPower = 7;
			attackN = 7;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AddLevel ();
		attackPowerNum.text = attackN.ToString ();
		levelNum.text = levelN.ToString ();
	}
}
