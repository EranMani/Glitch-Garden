using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] int minSpawnDelay, maxSpawnDelay;
    [SerializeField] Attacker[] attackerPrefabs;

    IEnumerator Start()
    {
        while (spawn)
        {
            int spawnTime = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(spawnTime);
            SpawnAttacker();


        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        int attackerTypeIndex = Random.Range(0, attackerPrefabs.Length);
        Spawn(attackerPrefabs[attackerTypeIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker, transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }
}
