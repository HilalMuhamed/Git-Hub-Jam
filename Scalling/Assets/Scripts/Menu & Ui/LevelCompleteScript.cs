using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1;
      public GameObject Particle;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(Particle,transform.position,Quaternion.identity);
            StartCoroutine(LoadLevel((SceneManager.GetActiveScene().buildIndex )+ 1));
            
        }
    }
    
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        Debug.Log("Next Level Reached");
        SceneManager.LoadScene(levelIndex);
    }

}