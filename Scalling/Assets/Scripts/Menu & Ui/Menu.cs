using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
        public GameObject PauseMenuUI;
    public GameObject MenuUI;
    public void StartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1f;
    }
    public void PauseBtn()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale=0f;
        MenuUI.SetActive(false);
    }
    public void ResumeBtn()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        MenuUI.SetActive(true);
    }
    public void HomeBtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale=1f;
    }

}
