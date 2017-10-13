using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColorFading : MonoBehaviour {

    [SerializeField]
    private Material mat;

    // Use this for initialization
    void Update () {
		if(Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine("Fade");
        }
	}
	
	// Update is called once per frame
	private IEnumerator Fade () {
		for(float i = 0; i < 1; i+=0.01f)
        {
            mat.color = new Color(0, i, i);
            yield return null;
        }
    }
}