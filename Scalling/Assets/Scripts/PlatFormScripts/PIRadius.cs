using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class PIRadius : MonoBehaviour
{
    public PiGrapleHook p;
    void Start()
    {
        p=GameObject.FindWithTag("Player").GetComponent<PiGrapleHook>();
    }
   void OnDrawGizmosSelected()
    {
        Handles.color = Color.green;
        Handles.DrawWireDisc(transform.position,transform.forward,p.maxDistance);    
    }
}
