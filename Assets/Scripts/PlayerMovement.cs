using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sideWays = 200f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //this code launches the cube
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //transform.rotation = Quaternion.identity;
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
