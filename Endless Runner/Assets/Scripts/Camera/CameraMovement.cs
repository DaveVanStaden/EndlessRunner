using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform target;


    void Update()
    {
        transform.position = new Vector3(0, target.position.y, transform.position.z);
    }
}
