using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")){
            rb.AddForce(transform.forward*Time.deltaTime*1000);
        }
        if (Input.GetKey("d")){
            rb.AddForce(transform.right*Time.deltaTime*1000);
        }
        if (Input.GetKey("a")){
            rb.AddForce(transform.right*Time.deltaTime*-1000);
        }
        if (Input.GetKey("s")){
            rb.AddForce(transform.forward*Time.deltaTime*-1000);
        }
        
    }
}
