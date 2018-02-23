using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMovement : MonoBehaviour
{
	public float speed;

	private Transform hero;
	private Vector3 initPosition;
	private GameObject player;
	private float distance;
	private Vector3 prevPosition;
	private Vector3 newPosition;
	private Animator anim;
	private Rigidbody2D r2d;

	void Awake ()
	{
		initPosition = transform.position;
		anim = GetComponent<Animator> ();
		r2d = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		hero = player.transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Debug.DrawLine (hero.position, transform.position, Color.red);

		//newPosition = Vector3.zero;
		distance = Vector3.Distance (hero.position, transform.position);
		if (distance < 15) {
			if (distance < 2) {
				// Attack player

			} else {
				// move toward player
				newPosition = Vector3.MoveTowards (transform.position, hero.position, speed * Time.deltaTime);
				r2d.MovePosition (newPosition);
//
			}
				
			if (transform.position != initPosition) {
				anim.SetBool ("iswalking", true);
				prevPosition = transform.position;
			} else {
				anim.SetBool ("iswalking", false);
				newPosition = prevPosition;
			}

			// no diagonal movement
			
	
		} else {
			// back to original position
			newPosition = Vector3.MoveTowards (transform.position, initPosition, speed * Time.deltaTime);
			r2d.MovePosition (newPosition);
			if (transform.position.Equals (initPosition)) {
				anim.SetBool ("iswalking", false);
			}
			// idling 

		}
		//transform.position += newPosition * speed * Time.deltaTime;

//		if (newPosition.sqrMagnitude > 0) {
//			anim.SetBool ("iswalking", true);
//			prevPosition = newPosition;
//		} else {
//			anim.SetBool ("iswalking", false);
//			newPosition = prevPosition;
//		}
	
		anim.SetFloat ("input_x", (transform.position.x > hero.position.x ? -1f : 1f));
		anim.SetFloat ("input_y", (transform.position.y > hero.position.y ? -1f : 1f));
	}

}
