using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName; // The name of the scene you want to transition to

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}