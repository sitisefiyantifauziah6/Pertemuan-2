using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonController : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene you want to load
    public GameObject SubbabMateri; // Reference to the Material Subchapter object

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Load the scene specified in the "sceneToLoad" variable
    }

    public void GoToSubbabMateri()
    {
        if (SubbabMateri != null)
        {
            // You can perform actions like moving the camera to focus on the object.
        }
    }
}
