using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private bool over = false;
    private bool hasLastChance = false;


    public bool getLastChanceState()
    {
        return hasLastChance;
    }
    public void getLastChance()
    {
        hasLastChance = true;
    }
    public bool isGameOver()
    {
        return over;
    }
    public void gameOver()
    {
        if (!hasLastChance)
            over = true;
        else
            hasLastChance = false;
    }
    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
