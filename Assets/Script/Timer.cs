using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text timeText;
    private bool timerRunning = true;


    void Start()
    {
        timeText.text = timeStart.ToString();
    }

    void FixedUpdate()
    {
        if (timerRunning)
        {
            timeStart -= Time.deltaTime;
            timeText.text = Mathf.Round(timeStart).ToString();
        }
        if (timeStart < 0)
            timeStart = 0;

        if (GameObject.Find("Player").GetComponent<PlayerControl>().scoreText.text == "You lose!")
            timeStart = 0;
        else if (GameObject.Find("Player").GetComponent<PlayerControl>().scoreText.text == "You win!")
            timerRunning = false;

    }
}
