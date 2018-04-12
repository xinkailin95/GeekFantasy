using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameManager : MonoBehaviour {

	public bool isPaused = true;
	public GameObject menuGo;
	public GameObject controlPanel;
	public GameObject[] targetGOs;


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
		Time.timeScale = 1;

	}

	public void Quit(){
		Application.Quit ();
	}
	private Save CreateSaveGO()
	{
		Save save = new Save();
		for (int i = 0; i < 16; i++) {
			save.enemyLife1.Add (EnemyManager._instance.enemyLife [i]);

		}
		for (int i = 0; i < NPCManager._instance.NPCManagers.Length; i++) {
			if (NPCManager._instance.NPCManagers [i].GetComponent<NPC>().ifTalked == false) {
				save.NPCtype [i] = 0;
			} else {
				save.NPCtype [i] = 1; 
			}
		}

		save.playerLife = Player._instance.curplayerLife;
		save.levelNum = UIManager._instance.levelN;
		//save.scoreNum = UIManager._instance.scoreN;
		save.attackNum = UIManager._instance.attackN;
	
		return save;
	}
	private void SetGame(Save save)
	{
		for (int i = 0; i < 16; i++) {

			EnemyManager._instance.enemyLife [i] = save.enemyLife1 [i];
		}
		for (int i = 0; i < NPCManager._instance.NPCManagers.Length; i++) {
			if (save.NPCtype [i] == 1) {
				NPCManager._instance.NPCManagers [i].GetComponent<NPC>().ifTalked = true;
				UIManager._instance.scoreN += 3; 
			} else {
				NPCManager._instance.NPCManagers [i].GetComponent<NPC>().ifTalked = false;
			}
		}

		Player._instance.curplayerLife = save.playerLife;
		UIManager._instance.attackN = save.attackNum;
		//UIManager._instance.scoreN = save.scoreNum;
		UIManager._instance.levelN = save.levelNum;
	}
	private void SaveByBin()
	{
		Save save = CreateSaveGO();
		BinaryFormatter bf = new BinaryFormatter();
		FileStream fileStream = File.Create(Application.dataPath + "/StreamingFile" + "/byBin.txt");
		bf.Serialize(fileStream, save);
		fileStream.Close();
		if (File.Exists(Application.dataPath + "/StreamingFile" + "/byBin.txt"))
		{
			UIManager._instance.ShowMessage("SAVED");
		}
	}


	private void LoadByBin()
	{
		if(File.Exists(Application.dataPath + "/StreamingFile" + "/byBin.txt"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream fileStream = File.Open(Application.dataPath + "/StreamingFile" + "/byBin.txt", FileMode.Open);
			Save save = (Save)bf.Deserialize(fileStream);
			fileStream.Close();
			SetGame(save);
			UIManager._instance.ShowMessage("");
		}
		else
		{
			UIManager._instance.ShowMessage("NO FILE");
		}
	}
	public void SaveGame()
	{
		SaveByBin ();
	}
	public void LoadGame()
	{
		LoadByBin();

	}
}
