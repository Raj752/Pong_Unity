using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWallBehavior : MonoBehaviour {


    void OnCollisionEnter(Collision collision)
    {
        StartButton.isBallActive = false;
        if (gameObject.name == "RightWall")
        {
            ScoreTracker.scoreLeft += 1;
        }
        else
        {
            ScoreTracker.scoreRight += 1;
        }
        Destroy(collision.gameObject);

    }

}
