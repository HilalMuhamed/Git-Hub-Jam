using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailScript : MonoBehaviour
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
    void Start()
    {
        lineRend.positionCount = length;
        segmentPoses= new Vector3[length];
        segmentV= new Vector3[length];
    }
    void Update()
    {
        wiggleDir.localRotation = Quaternion.Euler(0,0,Mathf.Sin(Time.time*WiggleSpeed)*WiggleMagnitude);
        segmentPoses[0]=targetDir.position;
        for(int i=1;i<segmentPoses.Length;i++)
        {
            segmentPoses[i]=Vector3.SmoothDamp(segmentPoses[i],segmentPoses[i-1] + targetDir.right *targetDist,ref segmentV[i],smoothSpeed + i/trailSpeed);
        }
        lineRend.SetPositions(segmentPoses);
    }
}
