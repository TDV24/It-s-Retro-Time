using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPowerUpHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        // FindObjectOfType<GameManager>().getLastChange();
    }
}
