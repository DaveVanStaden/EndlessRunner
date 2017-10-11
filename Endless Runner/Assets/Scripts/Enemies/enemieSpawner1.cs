using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemieSpawner1 : MonoBehaviour {
    public Transform[] Enemy;
    public float spawnTimeDecrease = 0.2f;
    private double[] waitTime;

    float _timer;
    
    private void Start()
    {
        waitTime = new double[4];

        waitTime[0] = 6;
        waitTime[1] = 8;
        waitTime[2] = 9;
        waitTime[3] = 10;
    }
    void Update()
    {
        _timer += Time.deltaTime;

        for (int i = 0; i < waitTime.Length; i++)
        {
            Debug.Log(waitTime[i]);
            if (_timer >= waitTime[i])
            {
                SpawnEnemy(i);
                    _timer = 0;
            }
            if (waitTime[i] <= 1) waitTime[i] = 1;
        }
    }

    void SpawnEnemy(int j)
    {
            Vector3 pos = new Vector3(Random.Range(-4, 3), 1, Random.Range(0, -1));
            Transform enemies = Instantiate(Enemy[j]) as Transform;
            enemies.Translate(pos);
        waitTime[j] -= (waitTime[j] + spawnTimeDecrease);
    }
}
