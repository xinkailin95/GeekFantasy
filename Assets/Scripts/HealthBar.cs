using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public int maxEnemyLife;
    public int enemyNum;
    //public GameObject ;
    //public

    private void Awake()
    {
        enemyNum = (this.transform.parent.name[5] - '0') * 10 + (this.transform.parent.name[6] - '0');
        
        Debug.Log(this.transform.parent.name);
    }

    // Use this for initialization
    void Start () {
        if (enemyNum != 0)
        {
            transform.position = transform.position - new Vector3(0, 1, 0);
        }

        maxEnemyLife = EnemyManager._instance.enemyLife[enemyNum];
        Debug.Log(maxEnemyLife);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(enemyNum);
        transform.localScale = new Vector3(7f*EnemyManager._instance.enemyLife[enemyNum]/maxEnemyLife, 3.5f, 1);
    }
}
