using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Save{

	// Use this for initialization

	public List<int> enemyLife1 = new List<int>();
	public int[] NPCtype = new int[5];
	public int playerLife;


	public int scoreNum = 0;
	public int levelNum = 0;
	public int attackNum = 0;
}
