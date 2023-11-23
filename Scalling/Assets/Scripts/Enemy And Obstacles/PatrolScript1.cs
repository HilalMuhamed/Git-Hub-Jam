using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript1 : MonoBehaviour
{
   public GameObject Point1,Point2;
   public float speed;
   private Rigidbody2D rb;
   private bool direction = true;
   void Start()
   {
    rb=GetComponent<Rigidbody2D>();
    transform.position=Point1.transform.position;
   }
   void Update()
   {
    if(Vector2.Distance(transform.position,Point1.transform.position)<0.02f && direction)
    {
        direction=false;
    }
    if(Vector2.Distance(transform.position,Point2.transform.position)<0.02f && !direction)
    {
        direction=true;
    }
    if(direction)
    {transform.position = Vector2.MoveTowards(transform.position,Point1.transform.position,speed*Time.deltaTime);}
    else
    {transform.position = Vector2.MoveTowards(transform.position,Point2.transform.position,speed*Time.deltaTime);}
   }
   
   private void OnDrawGizmos()
   {
    Gizmos.DrawWireSphere(Point1.transform.position,1f);
    Gizmos.DrawWireSphere(Point2.transform.position,1f);
    Gizmos.DrawLine(Point1.transform.position,Point2.transform.position);
   }
}
