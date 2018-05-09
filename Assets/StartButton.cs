using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    // Use this for initialization

    public Button myButton;
    public GameObject BallPrefab;
    public GameObject ArenaPrefab;
    public GameObject LRWalls;
    public static bool isBallActive;


    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Instantiate(BallPrefab);
        Instantiate(ArenaPrefab);
        Instantiate(LRWalls);
        isBallActive = true;
        ScoreTracker.scoreLeft = 0;
        ScoreTracker.scoreRight = 0;
    }
}
