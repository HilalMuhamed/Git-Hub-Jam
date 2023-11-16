using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideGravity : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        Rigidbody2D playerRb = other.gameObject.GetComponent<Rigidbody2D>();
        playerRb.gravityScale = -playerRb.gravityScale;
        }
    }
}
