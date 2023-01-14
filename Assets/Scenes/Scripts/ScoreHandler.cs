using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class ScoreHandler : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;
    private float scoreValue = 0;
    private bool savedScoreThisSession = false;

    private GameManager gameManager;

    public void setScore(float value)
    {
        scoreValue = value;
    }

    public void incrementScore(float incrementValue)
    {
        scoreValue += incrementValue;
    }

    public void persistCurrentScore()
    {
        if (scoreValue > 0)
        {
            if (!Directory.Exists(Application.streamingAssetsPath + "/ScoreHistory"))
                Directory.CreateDirectory(Application.streamingAssetsPath + "/ScoreHistory");
            if (!File.Exists(Application.streamingAssetsPath + "/ScoreHistory" + "/ScoreHistory.dat"))
                File.Create(Application.streamingAssetsPath + "/ScoreHistory" + "/ScoreHistory.dat");
            File.AppendAllText(Application.streamingAssetsPath + "/ScoreHistory" + "/ScoreHistory.dat", System.DateTime.Now + "-->" + scoreText.text + "\n");
        }
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("{0:N0}", scoreValue);
        if (!savedScoreThisSession && gameManager.isGameOver())
        {
            savedScoreThisSession = true;
            persistCurrentScore();
        }

    }
}
