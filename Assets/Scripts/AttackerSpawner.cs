﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] int minSpawnDelay, maxSpawnDelay;
    [SerializeField] Attacker attackerPrefab;

    IEnumerator Start()
    {
        while (spawn)
        {
            int spawnTime = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(spawnTime);
            Instantiate(attackerPrefab, transform.position, Quaternion.identity);       
        }
    }

    void Update()
    {
        
    }
}