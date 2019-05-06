using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    private void Start()
    {
        // When the player loses, reset the time they took to play the game
        PlayerPrefs.SetFloat("min", 0f);
        PlayerPrefs.SetFloat("sec", 0f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Button functionality
    public void PlayAgain()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
