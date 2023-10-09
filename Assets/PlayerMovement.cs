using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
        
    }

    // We marked this as "Fixed"Update because we are using it to
    // mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
            // Only executed if condition is met
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
            // Only executed if condition is met
        }
    }
}
