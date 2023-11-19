using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayer : MonoBehaviour
{
    public GameObject deathParticle;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(deathParticle,other.gameObject.transform.position,Quaternion.identity);
            other.gameObject.SetActive(false);
            Invoke("RestartGame",2f);
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
