using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelController : MonoBehaviour
{
    [SerializeField] float waitToLoad = 4f;
    [SerializeField] GameObject winDisplay;
    [SerializeField] GameObject loseDisplay;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    AudioSource audioSource;
    LevelLoader levelLoader;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        levelLoader = FindObjectOfType<LevelLoader>();
        winDisplay.SetActive(false);
        loseDisplay.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (levelTimerFinished && numberOfAttackers <= 0)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        winDisplay.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(waitToLoad);
        levelLoader.LoadNextScene();
    }

    public void HandleLoseCondition()
    {
        loseDisplay.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
