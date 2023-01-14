using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColider : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacles")
        {
            FindObjectOfType<GameManager>().gameOver();
        }

    }
}
