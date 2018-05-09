using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Vector3 rayDirection;
    public Vector3 prevPosition = new Vector3 (0, 0, 0);
    public float speedFactor = 1.0F;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(4, 0, 4, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        rayDirection = (transform.position - prevPosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, rayDirection, 0.4F))
        {
            Vector3 incomingVec = hit.point - transform.position;
            Vector3 reflectVec = speedFactor * Vector3.Reflect(incomingVec, hit.normal);
            rb.velocity = -reflectVec;
            speedFactor = speedFactor + 0.05F;
        }
        prevPosition = transform.position;
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Wall")
    //    {
    //        Vector3 ballVelocity = rb.velocity;
    //        ballVelocity = new Vector3(ballVelocity.x, ballVelocity.y, -ballVelocity.z);
    //        rb.velocity = ballVelocity;

    //    }
    //    else if (collision.gameObject.tag == "Block")
    //    {
    //        Vector3 ballVelocity = rb.velocity;
    //        ballVelocity = new Vector3(-ballVelocity.x, ballVelocity.y, ballVelocity.z);
    //        rb.velocity = ballVelocity;
    //    }
    //}

}
