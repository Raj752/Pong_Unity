using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBlockMovement : MonoBehaviour
{
    public float moveInput = 0;
 

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (moveInput > 0)
        {
            upMove();
        }
        else if (moveInput < 0)
        {
            downMove();
        }
        moveInput = Input.GetAxis("VerticalRight");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            moveInput = 0;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            moveInput = 0;
        }
    }

    void upMove ()
    {
        Vector3 curPosition = transform.position;
        Vector3 newPosition = curPosition + new Vector3(0.0F, 0.0F, 0.2F);
        transform.position = Vector3.Slerp(curPosition, newPosition, 1.0F);
    }

    void downMove()
    {
        Vector3 curPosition = transform.position;
        Vector3 newPosition = curPosition + new Vector3(0.0F, 0.0F, -0.2F);
        transform.position = Vector3.Slerp(curPosition, newPosition, 1.0F);
    }
}
