using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float ObstacleSpeed;
    public float DestroyTime;
    void Start(){Destroy(gameObject,DestroyTime);}
    void FixedUpdate()
    {
        
        transform.position = transform.position + (Vector3.up *ObstacleSpeed*Time.deltaTime);    
    }
}
