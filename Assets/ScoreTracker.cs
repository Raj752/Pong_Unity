using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTracker : MonoBehaviour {

    public static int scoreLeft;
    public static int scoreRight;
    public Text displayScoreLeft;
    public Text displayScoreRight;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        displayScoreLeft.text = scoreLeft.ToString();
        displayScoreRight.text = scoreRight.ToString();
	}
}
