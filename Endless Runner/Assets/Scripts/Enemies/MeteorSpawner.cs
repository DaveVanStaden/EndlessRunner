using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {
    public Transform Enemy;
    bool timer;
    float time = 0;
    double speedup = 0;
    double waittime = 400;

    void Update()
    {
        if (timer == true)
        {
            Vector3 pos = new Vector3(Random.Range(6, 12), 8,0);
            Transform enemies = Instantiate(Enemy) as Transform;
            enemies.Translate(pos);
            time = 0;
            waittime -= 1;
        }
        if (timer == false)
        {
            time += 1;

        }
        if (time >= waittime - speedup)
        {
            timer = true;
        }
        if (time <= 1)
        {
            timer = false;

        }
        if (waittime <= 1)
        {
            waittime = 1;
        }

    }
}
