using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenHandler : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject gameOverScreen;
    private GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver())
        {
            gameOverScreen.SetActive(true);
        }
    }
}
