using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private int dir = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") && Input.GetKey("d"))
        {
            dir = 0;
        } else if(Input.GetKey("d"))
        {
            dir = 1;
        } else if(Input.GetKey("a"))
        {
            dir = -1;
        } else
        {
            dir = 0;
        }
    }

    private void FixedUpdate()
    {

        rb.AddForce(dir * sidewaysForce * Time.deltaTime, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);




    }
}
