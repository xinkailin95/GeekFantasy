using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyBoss : MonoBehaviour
{
	public static EnemyBoss _instance;
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
	bool loop;
	public GameObject enemyBulletPre;
	private float timeVal;
	public GameObject healthBar;
	public int boss_attack_mode;


	//public int enemyLife = 3;

	void Awake ()
	{
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

		float x = Random.Range (-20, 20);
		float y = Random.Range (-20, 20);
		rPosition = new Vector3 (initPosition.x + x, initPosition.y + y, initPosition.z);
		currentDest = rPosition;
		loop = true;
		boss_attack_mode = 1;

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

		if (timeVal >= 1.5f) {
			boss_attack_mode = 1 - boss_attack_mode;
			EnemyAttack (distance - 5f);
			timeVal = 0;

		} else {

			timeVal += Time.deltaTime;

		}
	}


	private void EnemyAttack (float a)
	{
		if (a < 10 && Player._instance.curplayerLife > 0) {
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -90 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 180 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 90 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 45 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -45 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, 135 + 22.5f * boss_attack_mode)));
			Instantiate (enemyBulletPre, transform.position, Quaternion.Euler (transform.eulerAngles + new Vector3 (0, 0, -135 + 22.5f * boss_attack_mode)));
		}
	}
}