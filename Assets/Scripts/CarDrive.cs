using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    public GameObject Player;
    public float angle;
    public bool isDriven;
    public float car_forward_speed;
    public float car_backward_speed;
    public float car_forward_rotate_speed;
    public float car_backward_rotate_speed;

    private Vector3 rot;
    private float car_h;
    private float car_v;
    private float car_angle;
    private bool get_on_just_now;

    // Use this for initialization
    void Start()
    {
        isDriven = false;
        car_forward_speed = 12f;
        car_backward_speed = 4.5f;
        car_forward_rotate_speed = 4f;
        car_backward_rotate_speed = 1.5f;
        Player = GameObject.Find("Player");

    }

    public bool hitself()
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + new Vector2(-2.5f, 0), pos);
        //	    Debug.DrawRay (dir + dir - pos, (pos - dir) * 100, Color.blue);
        //		Debug.Log (hit.collider);
        return (hit.collider == GetComponent<BoxCollider2D>()/*&& hit.collider != enemyArray[num].GetComponent<Collider2D>()*/);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < 2 && this.isDriven == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                //get in the car
                this.isDriven = true;
                Player.GetComponent<Renderer>().enabled = false;
                Player.GetComponent<CapsuleCollider2D>().enabled = false;
                Player.GetComponent<Player>().isInitial = false;
                get_on_just_now = true;
            }
        }
        if (this.isDriven == true)
        {
            Player.transform.position = transform.position;
            car_h = Input.GetAxisRaw("Horizontal");
            car_v = Input.GetAxisRaw("Vertical");


            rot = new Vector3(0f, 0f, 0f);
            float car_rotate_speed = 0f;
            float speed = 0f;

            //set driving speed and rotate speed
            if (car_v > 0)
            {
                speed = car_forward_speed;
                car_rotate_speed = car_forward_rotate_speed;

            }
            else if (car_v < 0)
            {
                speed = car_backward_speed;
                car_rotate_speed = car_backward_rotate_speed;
            }

            if (car_h > 0)
            {
                rot = new Vector3(0f, 0f, -car_rotate_speed);
            }
            else if (car_h < 0)
            {
                rot = new Vector3(0f, 0f, car_rotate_speed);
            }

            //rotate, if backword rotate inversely
            if (car_v < 0)
                rot = -rot;
            gameObject.transform.Rotate(rot);

            //calculate the current angle
            car_angle = transform.rotation.eulerAngles.z / 360 * 2 * Mathf.PI;

            //move the car in term of angle
            transform.Translate(car_v * Vector3.left * speed * Mathf.Sin(car_angle) * Time.deltaTime, Space.World);
            transform.Translate(car_v * Vector3.up * speed * Mathf.Cos(car_angle) * Time.deltaTime, Space.World);

            //get off the car when there is no collider on the LHS of car
            if (Input.GetKeyDown(KeyCode.F) && !get_on_just_now && hitself())
            {

                isDriven = false;
                Player.GetComponent<Renderer>().enabled = true;
                Player.transform.position = transform.position + new Vector3(-2f, 0, 0);
                Player.GetComponent<CapsuleCollider2D>().enabled = true;
                Player.GetComponent<Player>().isInitial = true;
            }
        }
        get_on_just_now = false;
    }
}
