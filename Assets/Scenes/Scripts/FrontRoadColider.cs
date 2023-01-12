using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontRoadColider : MonoBehaviour
{
    // Start is called before the first frame update


    private GameObject roadPrefab;
    private GameObject[] obstaclesDistributions = new GameObject[5];
    private void Start()
    {
        roadPrefab = Resources.Load("Road") as GameObject;
        for (int i = 0; i < 5; i++)
        {
            obstaclesDistributions[i] = Resources.Load("Obstacles" + (i + 1)) as GameObject;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject spawnedRoad = Instantiate(roadPrefab, new Vector3(0, 0, 280), Quaternion.identity);
        spawnedRoad.name = "NewRoad";

        int randomIndex = Random.Range(0, 5);
        GameObject spawnedObstacles = Instantiate(obstaclesDistributions[randomIndex], new Vector3(0, 3, 180), Quaternion.identity);
        spawnedObstacles.name = "NewObstacles";
    }
}
