using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text timerText;
    public static float score;

	void Start () {
        score = 0;
	}
	void Update () {
        timerText.text = "score: " + score;
	}
}
