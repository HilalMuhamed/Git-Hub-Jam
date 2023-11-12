using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : MonoBehaviour
{
   public GameObject Point1,Point2;
   public float speed;
   private Rigidbody2D rb;
   private Transform currenPoint;
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
   private void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {other.transform.SetParent(transform);}
   }
   private void OnCollisionExit2D(Collision2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {other.transform.SetParent(null);}
   }
   
   private void OnDrawGizmos()
   {
    Gizmos.DrawWireSphere(Point1.transform.position,1f);
    Gizmos.DrawWireSphere(Point2.transform.position,1f);
    Gizmos.DrawLine(Point1.transform.position,Point2.transform.position);
   }
}
