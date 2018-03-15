using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;

	private Animator anim;
	private Vector3 prevPosition;
	private Vector3 newPosition;

	private SpriteRenderer sr;
	public Sprite[] playerSprite;// up right left down


	// Use this for initialization
	private void Awake(){
		sr = GetComponent<SpriteRenderer> ();
	}
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void Update ()
	{
		newPosition = Vector3.zero;

		if (Input.GetKey (KeyCode.A))	// move left
			newPosition.x = -1f;
			sr.sprite = playerSprite [2];
		if (Input.GetKey (KeyCode.D))	// move right
			newPosition.x = 1f;	
			sr.sprite = playerSprite [1];
		if (Input.GetKey (KeyCode.W))	// move up
			newPosition.y = 1f;
		if (Input.GetKey (KeyCode.S))	// move down
			newPosition.y = -1f;
		// no diagonal movement
		if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W) || (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D)) || (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.S)) || (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.A))) {
			anim.SetBool ("iswalking", false);
			newPosition = prevPosition;
		}

		transform.position += newPosition * speed * Time.deltaTime;

		if (newPosition.sqrMagnitude > 0) {
			anim.SetBool ("iswalking", true);
			prevPosition = newPosition;
		} else {
			anim.SetBool ("iswalking", false);
			newPosition = prevPosition;
		}

		anim.SetFloat ("input_x", newPosition.x);
		anim.SetFloat ("input_y", newPosition.y);

	}

}
