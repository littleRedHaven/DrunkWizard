using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 currVelo;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void Update()
    {
        
        //jump, returns Boolean value
        if(Input.GetKeyDown("space"))
        {
            //velocity y -- increase it by a certain amount
            GetComponent<Rigidbody>().linearVelocity = new Vector3(rb.linearVelocity.x, 5, rb.linearVelocity.z);
        }

        if (Input.GetKey("up"))
        {
            
            GetComponent<Rigidbody>().linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y,5);
        }

        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y,-5);
        }

        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(-5,rb.linearVelocity.y,rb.linearVelocity.z);
        }

        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(5,rb.linearVelocity.y,rb.linearVelocity.z);
        }
    }
    
}
