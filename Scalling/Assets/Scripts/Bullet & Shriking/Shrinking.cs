using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinking : MonoBehaviour
{
    // public MonoBehaviour scriptA;
    // public MonoBehaviour scriptB;
    // public Animator animator;
    // public RuntimeAnimatorController controller1;
    // public RuntimeAnimatorController controller2;
    public GameObject particles;
    private Rigidbody2D rb;
    public GameObject sound1;
    public bool isSwitched = false;

    private void Start()
    {
        // animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            isSwitched = !isSwitched;
            Instantiate(sound1,transform.position,Quaternion.identity);

            if (isSwitched)
            {
                // scriptA.enabled = true;
                // scriptB.enabled = false;
                // animator.runtimeAnimatorController = controller1;
                rb.mass *= 10f;
                transform.localScale *= 4f; 
                Instantiate(particles, transform.position, Quaternion.identity);
            }
            else
            {
                // scriptA.enabled = false;
                // scriptB.enabled = true;
                // animator.runtimeAnimatorController = controller2;
                rb.mass /= 10f;
                transform.localScale /= 4f; 
                Instantiate(particles, transform.position, Quaternion.identity);
            }
        }
    }
}
