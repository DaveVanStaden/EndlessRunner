using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTime : MonoBehaviour {
    public Text endText;

	void Start () {
    }

	void Update () {
        endText.text = "you Dodged: " + Timer.score;
    }
}
