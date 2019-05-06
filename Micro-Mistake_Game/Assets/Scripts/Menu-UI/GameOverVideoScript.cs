using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameOverVideoScript : MonoBehaviour
{
    // Initialize Variables
    public RawImage image;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    //private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
        //videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
        //videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Fractal1.mp4");
        //videoPlayer.Play();
    }

    IEnumerator PlayVideo()
    {
        //Add VideoPlayer to the GameObject
        videoPlayer = gameObject.AddComponent<VideoPlayer>();

        //Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false;

        //We want to play from video clip not from url

        //videoPlayer.source = VideoSource.VideoClip;

        // Vide clip from Url
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "https://docs.google.com/file/d/1hHYYqfEWgOeEzOOy4VSaPsQQajSC1zrG/preview?authuser=0";


        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

        //Assign the Audio from Video to AudioSource to be played
        videoPlayer.EnableAudioTrack(0, true);

        //Set video To Play then prepare Audio to prevent Buffering
        //videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        //Wait until video is prepared
        while (!videoPlayer.isPrepared)
        {
            yield return null;
        }

        Debug.Log("Done Preparing Video");

        //Assign the Texture from Video to RawImage to be displayed
        image.texture = videoPlayer.texture;

        //Play Video
        videoPlayer.Play();

        Debug.Log("Playing Video");
        while (videoPlayer.isPlaying)
        {
            Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
            yield return null;
        }

        Debug.Log("Done Playing Video");
    }
}
