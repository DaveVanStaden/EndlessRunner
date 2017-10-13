using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DikkeEnemieSpawner1 : MonoBehaviour {

    public Transform Enemy;
    bool timer;
    float time = 0;
    double speedup = 0;
    double waittime = 800;

    void Update()
    {
        if (timer == true)
        {
            Vector3 pos = new Vector3(Random.Range(-4, 3), 3, Random.Range(0, -1));
            Transform enemies = Instantiate(Enemy) as Transform;
            enemies.Translate(pos);
            time = 0;
            waittime -= 3;
        }
        if (timer == false)
        {
            time += 1;

        }
        if (time >= waittime )
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
