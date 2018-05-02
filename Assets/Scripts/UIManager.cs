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
	public Text keyNum;


	public GameObject win;
	public GameObject gameOver;

	public int levelN;
	public int scoreN;
	public int attackN;
	public int keyN;
	public int attackPower;
	public int attackPower_R;

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
			attackPower = 6;
			attackN = 6;
		} else if (scoreN >= 4 && scoreN < 10) {
			levelN = 2;
			attackPower = 10;
			attackN = 10;
		} else if (scoreN >= 11 && scoreN < 19) {
			levelN = 3;
			attackPower = 15;
			attackN = 15;

		} else if (scoreN >= 19) {
			levelN = 4;
			attackPower = 20;
			attackN = 20;
		}
	}
	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find ("Player");
		HealthSlider = GameObject.Find ("HealthBlock").GetComponent<Slider> ();
		gameOver.SetActive (false);
		win.SetActive (false);


	}

	// Update is called once per frame
	void Update ()
	{
		attackPower_R = attackPower + 3;
		AddLevel ();
		attackPowerNum.text = attackN.ToString ();
		levelNum.text = levelN.ToString ();
		scoreNum.text = scoreN.ToString ();
		keyNum.text = keyN.ToString ();

		//heyi
		HealthSlider.maxValue = player.GetComponent<Player> ().maxplayerLife;
		HealthSlider.value = player.GetComponent<Player> ().curplayerLife;

		if (player.GetComponent<Player> ().curplayerLife == 0) {
			gameOver.SetActive (true);
			Player._instance.isInitial = false;
		}
		if (EnemyManager._instance.enemyLife [0] < 0) {
			win.SetActive (true);
			Player._instance.isInitial = false;
		}

	}
	public void addKey(){
		keyN = keyN + 1;
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
