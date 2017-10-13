using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    float _timer;
    int turn = -1;
    
    // Update is called once per frame
    void Update () {
        _timer += Time.deltaTime;
        transform.Rotate(Vector3.forward * turn);
        if (_timer >= 1)
        {
            turn -= 1;
        }
    }
}
