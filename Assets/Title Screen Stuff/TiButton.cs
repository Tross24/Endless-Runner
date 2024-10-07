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
    public void Options()
    {
        SceneManager.LoadSceneAsync(2);
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
        //Takes you to title
    }
    public void FGpg1()
    {
        SceneManager.LoadSceneAsync(3);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg2()
    {
        SceneManager.LoadSceneAsync(4);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg3()
    {
        SceneManager.LoadSceneAsync(5);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg4()
    {
        SceneManager.LoadSceneAsync(6);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg5()
    {
        SceneManager.LoadSceneAsync(7);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg6()
    {
        SceneManager.LoadSceneAsync(8);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg7()
    {
        SceneManager.LoadSceneAsync(9);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void FGpg8()
    {
        SceneManager.LoadSceneAsync(10);
        Time.timeScale = 1;

        //Takes you to title
    }
    public void Night()
    {
        SceneManager.LoadSceneAsync(11);
        Time.timeScale = 1;

        //Takes you to title
    }
}
