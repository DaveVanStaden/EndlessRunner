using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("DeadScene");
            
        }
            

    }
}
