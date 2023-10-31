using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component on the "Information" object

    void Start()
    {
        // Make sure the video doesn't play on awake
        videoPlayer.playOnAwake = false;
    }

    void Update()
    {
        if (videoPlayer.isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                // The Enter key was pressed while the video is playing
                ReturnToMenu();
            }
        }
    }

    void ReturnToMenu()
    {
        // You can load the "Menu" scene or perform any action you want here
        SceneManager.LoadScene("MenuScene"); // Replace "MenuScene" with your actual scene name
    }
}
