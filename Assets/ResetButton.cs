using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour {

    public Button myButton;
    public GameObject BallPrefab;

    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (!StartButton.isBallActive)
        {
            Instantiate(BallPrefab);
            StartButton.isBallActive = true;
        }
    }
}
