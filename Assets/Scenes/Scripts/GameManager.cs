using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private bool over = false;

    public bool isGameOver(){
        return over;
    } 
    public void gameOver(){
        over = true;
    }
    public void restartScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
