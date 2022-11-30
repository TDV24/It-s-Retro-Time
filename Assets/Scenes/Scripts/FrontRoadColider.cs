using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRoadColider : MonoBehaviour
{
    // Start is called before the first frame update


    private GameObject roadPrefab;
    private void Start(){
        roadPrefab = Resources.Load("Road") as GameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject spawnedRoad =  Instantiate(roadPrefab, new Vector3(0, 0, 280), Quaternion.identity);
        spawnedRoad.name = "NewRoad";  
        Debug.Log("ceva");
    }
}
