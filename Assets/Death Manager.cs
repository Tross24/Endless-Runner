using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject deathScreenCanvas;


    private void Update()
    {
        Debug.Log(Time.timeScale);
    }

    public void ShowDeathScreen()
    {
        Time.timeScale = 1;
        deathScreenCanvas.SetActive(true);
        Time.timeScale = 0;

    }
    public void RestartGame()
    { 
        
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       Time.timeScale = 1;
       Debug.Log(Time.timeScale);

    }
    public void QuitGame()
    {

        Time.timeScale = 1;
        Application.Quit();
    }
}
