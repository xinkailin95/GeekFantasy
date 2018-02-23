using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure_move : MonoBehaviour {

    public float speed = 0.35f;
    //public float a = 1;
    private Vector2 dest = Vector2.zero;

    private void Start()
    {
        dest = transform.position;
    }


    private void FixedUpdate()
    {
        Vector2 temp = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(temp);
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                dest = (Vector2)transform.position + Vector2.up;
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                dest = (Vector2)transform.position + Vector2.left;
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) 
            {
                dest = (Vector2)transform.position + Vector2.down;
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                dest = (Vector2)transform.position + Vector2.right;
            }

            Vector2 dir = dest - (Vector2)transform.position;
            GetComponent<Animator>().SetFloat("f_x", dir.x);
            GetComponent<Animator>().SetFloat("f_y", dir.y);
        }
    }

    /*  code for detecting if the figure is going to hit the collider*/
    /*
    private bool Valid(Vector2 dir)
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
    */
}
