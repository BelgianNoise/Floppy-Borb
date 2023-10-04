using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverPanel;
    public AudioSource scoreSound;

    [ContextMenu("Add Score")]
    public void addScore()
    {
        if (gameOverPanel.activeSelf) return;
        score++;
        scoreText.text = score.ToString();
        scoreSound.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
