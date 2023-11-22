using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    // public Animator transition;
    public int Respawn;
    public float transitionTime = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadLevel((SceneManager.GetActiveScene().buildIndex )+ 1));
            
        }
    }
    
    IEnumerator LoadLevel(int levelIndex)
    {
        // transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        Debug.Log("Next Level Reached");
        SceneManager.LoadScene(levelIndex);
    }

}