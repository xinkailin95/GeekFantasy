using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

	private float distance;
	public GameObject NPCtalking;
	public GameObject NPCtalkingB1;
	public GameObject NPCtalkingB2;
	public GameObject NPCtalkingB3;

	public GameObject NPCtalkingB5;
	public GameObject NPCtalkingB6;
	private List<GameObject> q = new List<GameObject> ();
	private List<GameObject> l = new List<GameObject> ();
	private bool ifTalked;
	private int i;

	// Use this for initialization
	void Start ()
	{
		ifTalked = false;
		q.Add (NPCtalkingB1);
		q.Add (NPCtalkingB2);
		q.Add (NPCtalkingB3);

		l.Add (NPCtalkingB5);
		l.Add (NPCtalkingB6);
		i = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance (Enemy._instance.hero.position, transform.position);
		if (ifTalked == false) {
			if (distance < 2 && Input.GetKeyDown (KeyCode.T)) {
				Player._instance.isInitial = false;
				if (i <= 2) {
					NPCtalking.SetActive (true);
					q [i].SetActive (true);
					Time.timeScale = 0;
					if (i > 0) {
						q [i - 1].SetActive (false);
					}

				}
						
				Debug.Log (i.ToString ());
				if (i == 3) {
					UIManager._instance.scoreN = UIManager._instance.scoreN + 3;
					NPCtalking.SetActive (false);
					Player._instance.isInitial = true;
					ifTalked = true;
					Time.timeScale = 1;
				}
				i = i + 1;
			} 
		} else if (ifTalked == true) {
			distance = Vector3.Distance (Enemy._instance.hero.position, transform.position);

			if (distance < 2 && Input.GetKeyDown (KeyCode.T) && l.Contains (NPCtalkingB6)) {
				NPCtalking.SetActive (true);
				Player._instance.isInitial = false;
				l [0].SetActive (true);
				l.RemoveAt (0);
				Time.timeScale = 0;
			} else if (!l.Contains (NPCtalkingB6)) {
				Player._instance.isInitial = true;
				NPCtalking.SetActive (false);
				ifTalked = true;
				Time.timeScale = 1;
				l.Add (NPCtalkingB5);
				l.Add (NPCtalkingB6);
			}
		}

	}
}
