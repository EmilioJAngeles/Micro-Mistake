using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Initialize Variables
    public Text timerText;
    public float seconds;
    public float minutes;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
        seconds = 0f;
        minutes = 0f;
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        // Records the time that it took for the player to win
        minutes = (int)(Mathf.Floor(Time.timeSinceLevelLoad / 60f));
        seconds = (int)(Mathf.Floor(Time.timeSinceLevelLoad % 60f));
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        PlayerPrefs.SetFloat("min", minutes);
        PlayerPrefs.SetFloat("sec", seconds);
    }
}
