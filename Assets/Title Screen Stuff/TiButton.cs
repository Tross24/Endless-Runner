using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TiButton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;

        //Takes you to Standard
    }
    public void Home()
    {
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Night()
    {
        SceneManager.LoadSceneAsync(3);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Sunset()
    {
        SceneManager.LoadSceneAsync(9);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Storm()
    {
        SceneManager.LoadSceneAsync(4);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Day()
    {
        SceneManager.LoadSceneAsync(5);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Options()
    {
        SceneManager.LoadSceneAsync(2);
        Time.timeScale = 1;

        //Takes you to title
    }
}
