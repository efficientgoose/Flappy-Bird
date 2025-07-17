using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    public static float currentPipeSpeed = 15f;
    public float speedIncreaseRate = 0.1f;
    
    private float logTimer = 0f;
    
    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        currentPipeSpeed = 15f; // Reset pipe speed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void Update()
    {
        currentPipeSpeed += speedIncreaseRate * Time.deltaTime;
        
        logTimer += Time.deltaTime;
        
        if (logTimer >= 1f)
        {
            logTimer = 0f;
            Debug.Log("Current Pipe Speed: " + currentPipeSpeed);
        }
    }
}