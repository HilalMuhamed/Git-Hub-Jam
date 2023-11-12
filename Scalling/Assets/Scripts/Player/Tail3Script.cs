using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail3Script : MonoBehaviour
{
    public int length;
    public LineRenderer lineRend;
    public Vector3[] segmentPoses;
    private Vector3[] segmentV;
    public Transform targetDir;
    public float targetDist;
    public float smoothSpeed;
    public float trailSpeed;
    public float WiggleSpeed;
    public float WiggleMagnitude;
    public Transform wiggleDir;
    public PlayerJump p;
    private bool direction;
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerJump>();
        lineRend.positionCount = length;
        segmentPoses= new Vector3[length];
        segmentV= new Vector3[length];
        direction = p.facingRight;
    }
    void Update()
    {
        wiggleDir.localRotation = Quaternion.Euler(0,0,Mathf.Sin(Time.time*WiggleSpeed)*WiggleMagnitude);
        segmentPoses[0]=targetDir.position;
        for(int i=1;i<segmentPoses.Length;i++)
        {
            if(direction){segmentPoses[i]=Vector3.SmoothDamp(segmentPoses[i],segmentPoses[i-1] + targetDir.right *targetDist,ref segmentV[i],smoothSpeed + i/trailSpeed);}
            else{segmentPoses[i]=Vector3.SmoothDamp(segmentPoses[i],segmentPoses[i-1] - targetDir.right *targetDist,ref segmentV[i],smoothSpeed + i/trailSpeed);}
        }
        lineRend.SetPositions(segmentPoses);
    }
}
