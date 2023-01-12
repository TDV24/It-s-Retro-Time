using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreHandler : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;
    private float scoreValue = 0;

    void Start()
    {

    }

    public void setScore(float value)
    {
        scoreValue = value;
    }

    public void incrementScore(float incrementValue)
    {
        scoreValue += incrementValue;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("{0:N0}", scoreValue);

    }
}
