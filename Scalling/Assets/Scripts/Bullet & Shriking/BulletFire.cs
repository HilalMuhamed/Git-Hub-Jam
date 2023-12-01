using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public float bulletSpeed;
    public PlayerJump p;
    private bool direction;
    public GameObject deathEffect1;

    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerJump>();
        direction = p.facingRight;
        Destroy(gameObject,5f);
    }
    void FixedUpdate()
    {
        if(direction)
        {transform.position = transform.position + (Vector3.right *bulletSpeed*Time.deltaTime);}
        else{transform.position = transform.position + (Vector3.left *bulletSpeed*Time.deltaTime);}

        
    }
    void OnCollisionEnter2D(Collision2D hit)
    {
        if(!(hit.gameObject.CompareTag("Player")))
        {// Instantiate(sound1, transform.position, Quaternion.identity);
        Instantiate(deathEffect1, transform.position, Quaternion.identity);
        // Instantiate(deathEffect2, transform.position, Quaternion.identity);
        Destroy(gameObject);}   
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!(other.CompareTag("Player")))
        {// Instantiate(sound1, transform.position, Quaternion.identity);
        Instantiate(deathEffect1, transform.position, Quaternion.identity);
        // Instantiate(deathEffect2, transform.position, Quaternion.identity);
        Destroy(gameObject);}
    }
}
