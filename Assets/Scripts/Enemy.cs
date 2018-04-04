using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
	public static Enemy _instance;
	public float speed;
	public float backUptime = 0.1f;
	public int[,] enemyLife = new int[30, 2];
	public int attackPower = 1;
	public AudioSource enemydied;

	public Transform hero;
	private Vector3 initPosition;
	private GameObject player;
	private float distance;
	private Vector3 prevPosition;
	private Vector3 newPosition;
	private Rigidbody2D r2d;
	private Vector3 rPosition;
	private Vector3 currentDest;
	private Vector2 destination;
	private Animator anim;
	private List<bool> enemyIsD = new List<bool>();
	bool loop;

	//public int enemyLife = 3;

	void Awake ()
	{
		anim = GetComponent<Animator> ();
		initPosition = transform.position;
		r2d = GetComponent<Rigidbody2D> ();
		_instance = this;
	}

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		hero = player.transform;
		for (int i = 1; i < 30; i++) {
			enemyLife [i, 1] = 10;
			enemyIsD.Add (false);
		}

		enemyLife [0, 1] = 84;
		float x = Random.Range (-10, 10);
		float y = Random.Range (-10, 10);
		rPosition = new Vector3 (initPosition.x + x, initPosition.y + y, initPosition.z);
		currentDest = rPosition;
		loop = true;

	}

	// Update is called once per frame
	void Update ()
	{
		Debug.DrawLine (hero.position, transform.position, Color.red);

		//newPosition = Vector3.zero;
		distance = Vector3.Distance (hero.position, transform.position);
		if (distance < 15) {
			// move toward player
			newPosition = Vector3.MoveTowards (transform.position, hero.position, speed * Time.deltaTime);
			r2d.MovePosition (newPosition);

		} else if (loop == true) {
			// idling
			newPosition = Vector3.MoveTowards (transform.position, currentDest, speed * Time.deltaTime);
			r2d.MovePosition (newPosition);
			backUptime += 0.1f;
			// Debug.Log (backUptime);
			if (Vector3.Equals (transform.position, newPosition) || backUptime > 15f) {
				backUptime = 0.1f;
				loop = false;
			}
		} else {
			// back to original position
			newPosition = Vector3.MoveTowards (transform.position, initPosition, speed * Time.deltaTime);
			r2d.MovePosition (newPosition);
			if (Vector3.Equals (transform.position, newPosition)) {
				loop = true;
			}
		}

		Vector3 sub = newPosition - transform.position;
		anim.SetFloat ("input_x", (sub.x < 0 ? -1f : 1f));
		anim.SetFloat ("input_y", (sub.y < 0 ? -1f : 1f));
		for (int i = 1; i < 30; i++) {
			if (enemyLife [i, 1]<0 && enemyIsD[i] == false) {
				enemydied.Play ();
				enemyIsD [i] = true;
			}
		}
	}
}