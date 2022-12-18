using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRoadColider : MonoBehaviour
{


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameObject oldRoad =  GameObject.Find("OldRoad");
        if(oldRoad!=null){
            Destroy(oldRoad);
        }

        gameObject.transform.parent.name = "OldRoad";
        gameObject.transform.parent.transform.position += new Vector3(0,0,-200);

        GameObject oldObstacles = GameObject.Find("OldObstacles");
        if(oldObstacles!=null){
            Destroy(oldObstacles);
        }
        GameObject newObstacles = GameObject.Find("NewObstacles");
        newObstacles.transform.position+= new Vector3(0,0,-200);
        newObstacles.name = "OldObstacles";

        GameObject car = GameObject.Find("Car");
        car.transform.position+= new Vector3(0,0,-200);


       
        
    }
}
