using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonJump : MonoBehaviour
{
    public float bounce = 20f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce,ForceMode2D.Impulse);
        }    
    }
}
