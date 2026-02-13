using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    

    [ContextMenu("Increase Score")]
    public void add_score(int score_to_add)
    {
        score += score_to_add;
        scoreText.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
    /*public void freezePipes()
    {
        if 
    }

     public void freezeClouds()
    {
        if 
    }
    */
}
