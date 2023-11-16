using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusRotatingScript : MonoBehaviour
{
    public float rotationSpeed = 5f;
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
