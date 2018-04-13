using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public GameObject Inventory;
    public int indexOfItem;

	// Use this for initialization
	void Start () {
        indexOfItem = (gameObject.name[4] - '0') * 10 + (gameObject.name[5] - '0');
        Inventory = GameObject.Find("Inventory");
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Inventory.GetComponent<Inventory>().add(indexOfItem);
        Destroy(this.gameObject);
        //Debug.Log(indexOfItem);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
