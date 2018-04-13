using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public static UIManager _instance;


	public Text levelNum;
	public Text attackPowerNum;
	public Text scoreNum;
	public Text messageText;



	public int levelN;
	public int scoreN;
	public int attackN;
	public int attackPower;

	//heyi
	public Slider HealthSlider;
	public GameObject player;

	private void Awake ()
	{
		_instance = this;

	}

	public void AddScore ()
	{
		scoreN += 1;
	}

	private void AddLevel ()
	{
		if (scoreN < 4) {
			levelN = 1;
			attackPower = 1;
			attackN = 1;
		} else if (scoreN >= 4 && scoreN < 10) {
			levelN = 2;
			attackPower = 3;
			attackN = 3;
		} else if (scoreN >= 11 && scoreN < 19) {
			levelN = 3;
			attackPower = 5;
			attackN = 5;

		} else if (scoreN >= 19) {
			levelN = 4;
			attackPower = 7;
			attackN = 7;
		}
	}
	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find ("Player");
		HealthSlider = GameObject.Find ("HealthBlock").GetComponent<Slider> ();

	}

	// Update is called once per frame
	void Update ()
	{
		AddLevel ();
		attackPowerNum.text = attackN.ToString ();
		levelNum.text = levelN.ToString ();
		scoreNum.text = scoreN.ToString ();

		//heyi
		HealthSlider.maxValue = player.GetComponent<Player> ().maxplayerLife;
		HealthSlider.value = player.GetComponent<Player> ().curplayerLife;

	}
	public void ShowMessage(string str)
	{
		messageText.text = str;
		Invoke ("emptyStr", 0.5f);
	}
	public void emptyStr(){
		messageText.text = "";
	}

}
