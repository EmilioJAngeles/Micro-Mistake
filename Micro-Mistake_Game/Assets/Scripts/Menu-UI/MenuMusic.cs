using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    // Initialize Variables
    public AudioSource menuAudioSource;
    public static MenuMusic instance;

    private void Awake()
    {
        // check if there is an instance of the object in the hierarchy
        // if yes, then destroy this object. if no, do nothing
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        // Do not destroy this object when the game changes scenes
        DontDestroyOnLoad(this.gameObject);

        menuAudioSource = GetComponent<AudioSource>();
    }

    // Play music
    public void PlayMusic()
    {
        if (menuAudioSource.isPlaying == true)
        {
            return;
        } else if(menuAudioSource.isPlaying == false)
        menuAudioSource.Play();
    }

    // Stop music
    public void StopMusic()
    {
        menuAudioSource.Stop();
    }
}
