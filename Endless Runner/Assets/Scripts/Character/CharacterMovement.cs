using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed;
    public float speed_up;
    public bool key_left;
    public bool key_right;
    public bool key_up;
    public bool key_down;
    public Rigidbody2D rigidbody;

    private void Start()
    {
        Rigidbody2D rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()  // Input
    {
        key_left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        key_right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
    }

    private void Update()
    {
        if (key_left)
        {
            if (transform.position.x > -4.37 + 1.444032)
            {
                transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            }
        }
        else
        {
            
        }

        if (key_right)
        {
            if (transform.position.x < 3.64 - 1.709631)
                transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }

    }
}
