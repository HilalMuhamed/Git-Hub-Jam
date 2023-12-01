using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float ObstacleSpeed;
    public float DestroyTime;
    public GameObject deathparticle1;
    void Start(){Destroy(gameObject,DestroyTime);}
    void FixedUpdate()
    {
        
        transform.position = transform.position + (Vector3.up *ObstacleSpeed*Time.deltaTime);    
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if(!gameObject.CompareTag("Ballon")&&!hit.gameObject.CompareTag("Player")&&!hit.gameObject.CompareTag("Player"))
        {Instantiate(deathparticle1,transform.position,Quaternion.identity);
        Destroy(gameObject);}
    }
}
