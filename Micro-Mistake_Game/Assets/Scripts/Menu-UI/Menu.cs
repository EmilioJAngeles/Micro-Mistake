using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        GameObject.FindGameObjectWithTag("MenuMusicPlayer").GetComponent<MenuMusic>().PlayMusic();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Button Functionality
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
