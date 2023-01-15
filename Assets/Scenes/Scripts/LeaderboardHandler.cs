using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class LeaderboardHandler : MonoBehaviour
{

    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        string[] content;
        if (!File.Exists(Application.streamingAssetsPath + "/ScoreHistory" + "/ScoreHistory.dat")) content = new string[] { "No scores" };
        else content = File.ReadAllLines(Application.streamingAssetsPath + "/ScoreHistory" + "/ScoreHistory.dat");
        text = gameObject.GetComponent<TMP_Text>();
        for (int i = content.Length - 1; i > content.Length - 10; i--)
        {
            text.text = text.text + content[i] + '\n';
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
