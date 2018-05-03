using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Boss : MonoBehaviour
{
	public static Boss _instance;
	public float speed;
	public float backUptime = 0.1f;

	public int attackPower = 1;

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
	bool loop;
	public GameObject enemyBulletPre;
	private float timeVal;
	public GameObject healthBar;


	//public int enemyLife = 3;

	void Awake ()
	{
		anim = GetComponent<Animator> ();
		initPosition = transform.position;
		r2d = GetComponent<Rigidbody2D> ();
		_instance = this;

		Instantiate (healthBar, this.transform);

	}

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		hero = player.transform;

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
		if (distance < 15 && Player._instance.curplayerLife > 0) {
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

		if (timeVal >= 2f) {

			EnemyAttack (distance);
			timeVal = 0;

		} else {

			timeVal += Time.deltaTime;

		}
	}


	private void EnemyAttack (float a)
	{
		if (a < 10 && Player._instance.curplayerLife > 0) {
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 30)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 60)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles));
		}
	}
}