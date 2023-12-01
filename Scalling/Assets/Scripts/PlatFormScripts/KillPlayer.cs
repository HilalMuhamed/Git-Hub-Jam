using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayer : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1;
    public GameObject deathParticle,sound1;
    void Start()
    {
        transition =  GameObject.FindGameObjectWithTag("SceneTransition").GetComponent<Animator>();;
    }
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
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        Debug.Log("Next Level Reached");
        SceneManager.LoadScene(levelIndex);
    }
}
