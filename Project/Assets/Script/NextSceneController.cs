using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneController : MonoBehaviour
{
    public string PenjelasanAwalSceneName; // Specify the name of the menu scene in the Inspector.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Check for the "Enter" key press.
        {
            SceneManager.LoadScene(PenjelasanAwalSceneName); // Load the menu scene.
        }
    }
}
