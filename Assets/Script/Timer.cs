using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text timeText;
    private Text stopTime;

    void Start()
    {
        timeText.text = timeStart.ToString();
    
    }

    void FixedUpdate()
    {    
           timeStart -= Time.deltaTime;
           timeText.text = Mathf.Round(timeStart).ToString();
       
        if (timeStart < 0)
            timeStart = 0;
     
    }
}
