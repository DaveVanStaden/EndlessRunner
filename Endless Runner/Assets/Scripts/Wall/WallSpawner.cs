using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject character;
    public GameObject Wall;
    public Transform prefab;
    [SerializeField]
    private float _spawnThreshold;
    private float posY = 17.0f;
    private int timer = 5;
    private int quick = 250;

    private void Update()
    {
        timer = timer + 1;
        //Vector3 posThresshold = new Vector3(_spawnThreshold, 1, _spawnThreshold);
        float chY = character.transform.position.y;
        Debug.Log (chY);
        for (int i = 0; i < _spawnThreshold; i++)
        {
            //Instantiate(Wall, posThresshold, Quaternion.identity);
            //if (chY >= 10 && chY <= 12)
            if (timer == quick)
            {
                Transform wall = Instantiate(prefab) as Transform;
                wall.Translate(1, posY, 1 * wall.localScale.y);
                timer = 0;

            }

        }
        // is de speler voorbij de threshold of niet?
    }

}
