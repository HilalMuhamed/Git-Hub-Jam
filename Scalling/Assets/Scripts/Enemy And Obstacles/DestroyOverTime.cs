using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float DestroyTime = 5f;
    void Start(){Destroy(gameObject,DestroyTime);}
}
