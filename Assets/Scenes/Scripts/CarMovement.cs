using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    
    public Rigidbody rb;
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
/*        if (Input.GetKey("s")){
            rb.AddForce(transform.forward*Time.deltaTime*-1000);
        }
*/
        
    }
}
