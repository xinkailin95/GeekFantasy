using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureMove : MonoBehaviour {
    private float speed = 0.05f;
    private Vector2 dest = Vector2.zero;

	// Use this for initialization
	private void Start () {
        dest = transform.position;
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
        Vector2 temp = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(temp);
        
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            dest = (Vector2)transform.position + Vector2.up/5;
        }
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            dest = (Vector2)transform.position + Vector2.left/5;
        }
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            dest = (Vector2)transform.position + Vector2.down/5;
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            dest = (Vector2)transform.position + Vector2.right/5;
        }
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("F_X", dir.x);
        GetComponent<Animator>().SetFloat("F_Y", dir.y);
    }
}
