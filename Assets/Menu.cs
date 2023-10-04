using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        // SceneManager.LoadScene(1);
        SceneManager.LoadScene("GameScene");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
