using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 120f;
    public TMP_Text timeText;
    public GameObject gameOverPanel;
    public GameObject player;


    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
            currentTime = 0f;
            GameOver();
        }
        DisplayTime(currentTime);
    }
    void DisplayTime (float timeTodisplay)
    {
        if (timeTodisplay < 0)
        {
            timeTodisplay = 0;
            
        }
        
        
        else if (timeTodisplay > 0)
        {
            timeTodisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeTodisplay / 60);
        float seconds = Mathf.FloorToInt(timeTodisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        player.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}
