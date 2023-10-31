using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string nextSceneName; // Specify the name of the next scene in the Inspector.

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
