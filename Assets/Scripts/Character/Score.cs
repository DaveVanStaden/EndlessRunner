using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public Text timerText;
    public static float score = 0;

    void Start()
    {
    }
    void Update()
    {
        timerText.text = "score: " + score;
    }
}
