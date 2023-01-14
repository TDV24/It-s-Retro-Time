using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecondChangeIndicatorHandler : MonoBehaviour
{

    private GameManager gameManager;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.getLastChanceState())
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }

    }
}
