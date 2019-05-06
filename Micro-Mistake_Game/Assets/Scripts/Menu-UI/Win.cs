using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Initialize Variables
    public Text gameWinTimeText;
    public float endMinutes;
    public float endSeconds;

    Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        // Set score time message when win screen appears
        endMinutes = (int)(PlayerPrefs.GetFloat("min"));
        endSeconds = (int)(PlayerPrefs.GetFloat("sec"));
        gameWinTimeText = GameObject.Find("GameTimeText").GetComponent<Text>();
        gameWinTimeText.text = endMinutes.ToString("00") + ":" + endSeconds.ToString("00");

        // reset the value after the game ends and previous score has been shown
        PlayerPrefs.SetFloat("min", 0f);
        PlayerPrefs.SetFloat("sec", 0f);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Button Functions
    public void PlayAgain()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
