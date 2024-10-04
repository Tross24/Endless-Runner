using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject deathScreenCanvas;

    public void ShowDeathScreen()
    {

        deathScreenCanvas.SetActive(true);
        Time.timeScale = 0;

    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
    public void QuitGame()
    {

        Time.timeScale = 1;
        Application.Quit();
    }
}
