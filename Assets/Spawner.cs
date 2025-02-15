﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    private float spawnWait;
    public int startWait;
    public float spawnMostWait=10f;
    public float spawnLeastWait=2f;
    public bool stop = true;

    int randEnemy;
    void Start()
    {
        StartCoroutine(waitSpawner());
        
    }


    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (stop)
        {
            randEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }

    }
}
