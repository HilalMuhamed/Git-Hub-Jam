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
    // public GameObject bulletFireParticle;
    // public GameObject bulletFireParticle2;
    // public GameObject sound1;
    void Update()
    {
    if(!canFire)
    {
        timer +=Time.deltaTime;
        if(timer>timeBetweenFiring)
        {
            canFire =true;
            timer =0;
        }
    }
    if(Input.GetMouseButton(0) && canFire)
    {
        canFire =false;
        // CameraShaker.Instance.ShakeOnce(1f, 0.7f, 0.1f, 0.1f);
        // Instantiate(sound1,bulletTransform.position,Quaternion.identity);
        // Instantiate(bulletFireParticle,bulletTransform.position,Quaternion.identity);
        // Instantiate(bulletFireParticle2,bulletTransform.position,Quaternion.identity);
        Instantiate(bullet,bulletTransform.position,Quaternion.identity);

    }
}
}
