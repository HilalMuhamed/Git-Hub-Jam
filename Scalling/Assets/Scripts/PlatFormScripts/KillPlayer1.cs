using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayer1 : MonoBehaviour
{
    public float transitionTime = 1;
    public GameObject deathParticle,sound1;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(deathParticle,other.gameObject.transform.position,Quaternion.identity);
            Instantiate(sound1,other.gameObject.transform.position,Quaternion.identity);
            StartCoroutine(LoadLevel((SceneManager.GetActiveScene().buildIndex ),other));
        }
    }
    IEnumerator LoadLevel(int levelIndex,Collision2D other)
    {
        other.gameObject.SetActive(false);
        yield return new WaitForSeconds(transitionTime/2);
        Debug.Log("Next Level Reached");
        SceneManager.LoadScene(levelIndex);
    }
}
