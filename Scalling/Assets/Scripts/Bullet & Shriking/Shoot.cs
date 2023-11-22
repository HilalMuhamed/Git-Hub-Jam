using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletTransform;
    private float timer;
    public float timeBetweenFiring;
    private bool canFire = true;
    private bool isShooting = false;
    public GameObject bulletFireParticle;
    // public GameObject bulletFireParticle2;
    // public GameObject sound1;
    public Animator animator;

    public PiGrapleHook piGrapleHook;
    void Start()
    {
        animator=GetComponent<Animator>();
    }
    void Update()
    {
    animator.SetBool("Shooting",isShooting);
    if(!canFire)
    {
        timer +=Time.deltaTime;
        if(timer>timeBetweenFiring)
        {
            canFire =true;
            timer =0;
        }
    }
    if(Input.GetMouseButton(0) && canFire && !piGrapleHook._distanceJoint.enabled)
    {
        isShooting=true;
        canFire =false;
        // CameraShaker.Instance.ShakeOnce(1f, 0.7f, 0.1f, 0.1f);
        // Instantiate(sound1,bulletTransform.position,Quaternion.identity);
        Instantiate(bulletFireParticle,bulletTransform.position,Quaternion.identity);
        // Instantiate(bulletFireParticle2,bulletTransform.position,Quaternion.identity);
        Instantiate(bullet,bulletTransform.position,Quaternion.identity);
    }
    else{isShooting=false;}
}
}
