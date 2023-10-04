using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void OnPlayAgainButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnBackToMenuButtonPressed()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
