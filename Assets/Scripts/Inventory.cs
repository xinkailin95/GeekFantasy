using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public static Inventory _instance;

	public Sprite[] allItem = new Sprite[10];
	public string[] description;
	//public GameObject[] holdItem=new GameObject[3];
	public List<GameObject> holdItem;
	public List<int> itemNum;
	public GameObject Player;
	public GameObject chosenBorder;
	public int chosenNum;
	public bool isinventory;
	public GameObject itemDescription;


	private bool just_open_inventory;

	// Use this for initialization
	private void Awake ()
	{
		_instance = this;
	}

	void Start ()
	{
		Player = GameObject.Find ("Player");
		chosenBorder = GameObject.Find ("border");
		itemNum = new List<int> ();
		chosenNum = 0;
		isinventory = false;
		just_open_inventory = false;
		itemDescription = GameObject.Find ("ItemDescription");
		description = new[] {
			" ",
			"Amazing Curve: Restore some Hp",
			"C++ Primer: use to update your attack mode",
			"The theory of computation: study the new skill, press \"R\" to use it",
			"Python: study the new skill, double press \"W\",\"S\",\"A\",\"D\" use it",
			"Car's key: Hold it so that you can drive the car",
			" ",
			" ",
			" ",
			" "
		};

		for (int i = 0; i < 15; i++) {
			GameObject tmpSpace;
			if (i < 10)
				tmpSpace = GameObject.Find (this.name + "/space" + "0" + i.ToString ());
			else
				tmpSpace = GameObject.Find (this.name + "/space" + i.ToString ());
			if (tmpSpace != null)
				holdItem.Add (tmpSpace);
		}

		for (int i = 0; i < holdItem.Count; i++) {
			itemNum.Add (0);
		}

		itemDescription.SetActive (false);
	}

	// Update is called once per frame
	public void add (int numberOfItem)
	{
		for (int i = 0; i < itemNum.Count; i++) {
			if (itemNum [i] == 0) {
				itemNum [i] = numberOfItem;
				break;
			}
		}
	}

	public void remove (int indexOfCell)
	{
		itemNum.RemoveAt (indexOfCell);
		itemNum.Add (0);
	}

	public void use (int indexOfCell)
	{
		int numberOfItem = itemNum [indexOfCell];
		switch (numberOfItem) {
		case 0:
			break;
		case 1:
			remove (indexOfCell);    //For one-time item
			if (Player.GetComponent<Player> ().curplayerLife < Player.GetComponent<Player> ().maxplayerLife - 2) {
				Player.GetComponent<Player> ().curplayerLife = Player.GetComponent<Player> ().curplayerLife + 2;
			} else {
				Player.GetComponent<Player> ().curplayerLife = Player.GetComponent<Player> ().maxplayerLife;
			}
			break;
		case 2:
			remove (indexOfCell);
			Player.GetComponent<Player> ().canMultiple = true;
			Player.GetComponent<Player> ().setMultiple_attack ();
                //Player myplayer = new Player();
                //myplayer.m
			break;
		case 3:
			remove (indexOfCell);
			Player.GetComponent<Player> ().setDis_attack ();
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9:
			break;
		}

	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Q) && Player.GetComponent<Player> ().isInitial == true) {
			isinventory = true;
			Player.GetComponent<Player> ().isInitial = false;
			just_open_inventory = true;
			this.transform.position = Player.transform.position + Vector3.down * 4 + new Vector3 (0, 0, 10f);
			itemDescription.SetActive (true);
		}


		if (isinventory) {
			if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)) {
				chosenNum = (chosenNum + 1) % (holdItem.Count);
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A)) {
				chosenNum = (chosenNum + holdItem.Count - 1) % (holdItem.Count);
			}
			if (Input.GetKeyDown (KeyCode.Space) && holdItem [chosenNum].GetComponent<SpriteRenderer> ().sprite != null) {
				use (chosenNum);
			}

			chosenBorder.transform.position = holdItem [chosenNum].transform.position;

			if (Input.GetKeyDown (KeyCode.Q) && just_open_inventory == false) {
				isinventory = false;
				Player.GetComponent<Player> ().isInitial = true;
				this.transform.position = new Vector3 (-160f, -50f);
				itemDescription.SetActive (false);
			}
			just_open_inventory = false;
		}

		for (int i = 0; i < holdItem.Count; i++) {
			holdItem [i].GetComponent<SpriteRenderer> ().sprite = allItem [itemNum [i]];
			//Debug.Log(itemNum[i]);
		}

		itemDescription.GetComponent<Text> ().text = description [itemNum [chosenNum]];

	}
}
