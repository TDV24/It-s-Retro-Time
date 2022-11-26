using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRoadColider : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameObject oldRoad =  GameObject.Find("OldRoad");
        if(oldRoad!=null){
            Destroy(oldRoad);
        }

        gameObject.transform.parent.name = "OldRoad";
        gameObject.transform.parent.transform.position += new Vector3(0,0,-200);

        GameObject car = GameObject.Find("Car");
        car.transform.position+= new Vector3(0,0,-200);

       
        
    }
}
