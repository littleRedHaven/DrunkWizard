using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Vector3 currVelo;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().linearVelocity = new Vector3(10,0,-7);
    }

    //Update is called once per frame
    void Update()
    {
    
    }
    
    void OnCollision(Collision collision)
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(-rb.linearVelocity.x*2, 0, -rb.linearVelocity.z*2);
    }
}
