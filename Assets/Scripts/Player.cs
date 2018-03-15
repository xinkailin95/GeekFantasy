using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bulletPrefab;
	public float moveSpeed = 9;
	public Vector3 bulletEulerAngles;


	private SpriteRenderer sr;
	public Sprite[] playerSprite;// up right left down


	private void Awake(){
		sr = GetComponent<SpriteRenderer> ();
	}
 	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Attack ();
	}
	public void FixedUpdate(){
		float h = Input.GetAxisRaw ("Horizontal");
		transform.Translate (Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
		if (h < 0) {
			sr.sprite = playerSprite [2];
			bulletEulerAngles = new Vector3 (0, 0, 90);

		} 
		else if (h > 0) {
			sr.sprite = playerSprite [1];
			bulletEulerAngles = new Vector3 (0, 0, -90);	
		}
		float v = Input.GetAxisRaw ("Vertical");
		transform.Translate (Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);

		if (v < 0) {
			sr.sprite = playerSprite [3];
			bulletEulerAngles = new Vector3 (0, 0, -180);
		}
		else if (v > 0) {
			sr.sprite = playerSprite [0];
			bulletEulerAngles = new Vector3 (0, 0, 0);
		}
	}
	private void Attack(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, Quaternion.Euler (transform.eulerAngles + bulletEulerAngles));

		}
	}
}
