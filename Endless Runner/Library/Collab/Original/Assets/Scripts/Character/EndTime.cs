using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTime : MonoBehaviour {
    public Text endText;
    float endTime;
    string result;
	// Use this for initialization
	void Start () {
        endTime = Timer.startTime;
        result = Convert.ToString(result);
    }
	
	// Update is called once per frame
	void Update () {
        endText.text = "you survived for" + result;
    }
}
