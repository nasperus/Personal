using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject livesHolder;
    int score = 0;
    int lives = 3;
    public static GameManager instance;
    public GameObject gameOverPanel;
    bool gameOver = false;
    
   
    

    private void Awake()
    {
        instance = this; 
    }
   
    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
       
        if (lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawningCandies();
        //GameObject.Find("Player").GetComponent<Player>().canMove = false;
        gameOverPanel.SetActive(true);
    }


    public void IncrementeScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }
      
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    
}
