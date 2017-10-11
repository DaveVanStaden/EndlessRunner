using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor2Walk : MonoBehaviour {
    public float speed;

    void FixedUpdate()  // Input
    {
        //Movement down
        transform.position = new Vector3(transform.position.x + speed, transform.position.y - speed, transform.position.z);
    }
}
