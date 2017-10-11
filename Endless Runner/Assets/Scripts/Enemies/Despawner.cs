using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour {

    private void Update()
    {
        
        if(transform.position.y <= -10)
        {
            Timer.score += 1;
            Destroy(gameObject);
        }
    }
}
