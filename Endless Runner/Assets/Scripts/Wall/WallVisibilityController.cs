using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVisibilityController : MonoBehaviour {

    public GameObject target;
    public int range = 100;
    private RectTransform rt;

	// Use this for initialization
	void Start () {
        //RectTransform rt = (RectTransform)transform;
        transform.localScale = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		if
        (
            transform.position.x <= target.transform.position.x + range &&
            transform.position.x >= target.transform.position.x - range &&
            transform.position.y <= target.transform.position.y + range &&
            transform.position.y >= target.transform.position.y - range
        )
        {
            //transform.localScale = new Vector3(rt.rect.width, rt.rect.height, 1);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
	}
}
