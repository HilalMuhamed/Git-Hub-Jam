using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    public GameObject particles;
    public bool isSwitched = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
             isSwitched = !isSwitched;
             {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
            if (isSwitched)
            {
                // scriptA.enabled = true;
                // scriptB.enabled = false;
                // animator.runtimeAnimatorController = controller1;
                // rb.mass *= 5f;
                Instantiate(particles, transform.position, Quaternion.identity);
            }
            else
            {
                // scriptA.enabled = false;
                // scriptB.enabled = true;
                // animator.runtimeAnimatorController = controller2;
                // rb.mass /= 5f;
                Instantiate(particles, transform.position, Quaternion.identity);
            }
        }
    }
}
}
