using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// This code turned out to be a shitshow, but it works.
public class MenuGameOver : MonoBehaviour
{
    bool wow = false;
    public AudioSource wowSound;
    public AudioSource deathSound;

    public Text scoreText1, scoreText2, scoreText3, scoreText4, scoreText5;
    public Text dateText1, dateText2, dateText3, dateText4, dateText5;
    private int score1, score2, score3, score4, score5;
    private string date1, date2, date3, date4, date5;

    public void Start()
    {
        int score = PlayerPrefs.GetInt("score");
        Debug.Log("Score: " + score);
        PlayerPrefs.DeleteKey("score");

        score1 = PlayerPrefs.GetInt("lb1");
        score2 = PlayerPrefs.GetInt("lb2");
        score3 = PlayerPrefs.GetInt("lb3");
        score4 = PlayerPrefs.GetInt("lb4");
        score5 = PlayerPrefs.GetInt("lb5");
        date1 = PlayerPrefs.GetString("dt1");
        date2 = PlayerPrefs.GetString("dt2");
        date3 = PlayerPrefs.GetString("dt3");
        date4 = PlayerPrefs.GetString("dt4");
        date5 = PlayerPrefs.GetString("dt5");
        Debug.Log("Score1: " + score1);
        Debug.Log("Score2: " + score2);
        Debug.Log("Score3: " + score3);
        Debug.Log("Score4: " + score4);
        Debug.Log("Score5: " + score5);
        Debug.Log("Date1: " + date1);
        Debug.Log("Date2: " + date2);
        Debug.Log("Date3: " + date3);
        Debug.Log("Date4: " + date4);
        Debug.Log("Date5: " + date5);

        if (score > score1)
        {
            wow = true;
            score5 = score4;
            score4 = score3;
            score3 = score2;
            score2 = score1;
            score1 = score;
            date5 = date4;
            date4 = date3;
            date3 = date2;
            date2 = date1;
            date1 = DateTime.Now.ToString();
        } else if (score > score2)
        {
            score5 = score4;
            score4 = score3;
            score3 = score2;
            score2 = score;
            date5 = date4;
            date4 = date3;
            date3 = date2;
            date2 = DateTime.Now.ToString();
        } else if (score > score3)
        {
            score5 = score4;
            score4 = score3;
            score3 = score;
            date5 = date4;
            date4 = date3;
            date3 = DateTime.Now.ToString();
        } else if (score > score4)
        {
            score5 = score4;
            score4 = score;
            date5 = date4;
            date4 = DateTime.Now.ToString();
        } else if (score > score5)
        {
            score5 = score;
            date5 = DateTime.Now.ToString();
        }

        SaveLB();

        scoreText1.text = score1.ToString();
        scoreText2.text = score2.ToString();
        scoreText3.text = score3.ToString();
        scoreText4.text = score4.ToString();
        scoreText5.text = score5.ToString();
        dateText1.text = date1.ToString();
        dateText2.text = date2.ToString();
        dateText3.text = date3.ToString();
        dateText4.text = date4.ToString();
        dateText5.text = date5.ToString();

        if (wow)
        {
            wowSound.Play();
        } else
        {
            deathSound.Play();
        }
    }
    public void OnPlayAgainButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnBackToMenuButtonPressed()
    {
        SceneManager.LoadScene("MenuScene");
    }

    private void SaveLB()
    {
        PlayerPrefs.SetInt("lb1", score1);
        PlayerPrefs.SetString("dt1", date1.ToString());
        PlayerPrefs.SetInt("lb2", score2);
        PlayerPrefs.SetString("dt2", date2.ToString());
        PlayerPrefs.SetInt("lb3", score3);
        PlayerPrefs.SetString("dt3", date3.ToString());
        PlayerPrefs.SetInt("lb4", score4);
        PlayerPrefs.SetString("dt4", date4.ToString());
        PlayerPrefs.SetInt("lb5", score5);
        PlayerPrefs.SetString("dt5", date5.ToString());
        PlayerPrefs.Save();
    }
}
