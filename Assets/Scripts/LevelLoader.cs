using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadScreenTime;
    int currentIndex;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForLoad());
        }  
    }

    IEnumerator WaitForLoad()
    {
        yield return new WaitForSeconds(loadScreenTime);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game_Over");
    }
}
