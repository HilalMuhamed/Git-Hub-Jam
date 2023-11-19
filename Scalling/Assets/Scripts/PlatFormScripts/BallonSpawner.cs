using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawner : MonoBehaviour
{
    public GameObject Ballon;
    public GameObject Particles;
    public Transform[] spawnSpot;
    private float TimeBetweenSpawn;
    public float startTimeBetWeenSpawn;
    public float TimeDecrease;
    public float minTime;

void Start()
{TimeBetweenSpawn = startTimeBetWeenSpawn;}
void Update()
{
    if(TimeBetweenSpawn <=0)
    {
        int randpos = Random.Range(0,spawnSpot.Length);
        Instantiate(Ballon,spawnSpot[randpos].position,Quaternion.identity);
        Instantiate(Particles,spawnSpot[randpos].position,Quaternion.identity);
        TimeBetweenSpawn = startTimeBetWeenSpawn;
    }
    else{TimeBetweenSpawn -=Time.deltaTime;}
    if(startTimeBetWeenSpawn > minTime){startTimeBetWeenSpawn = startTimeBetWeenSpawn- TimeDecrease * Time.deltaTime;}
}
}
