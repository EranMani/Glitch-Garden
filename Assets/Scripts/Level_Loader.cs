using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Loader : MonoBehaviour
{
    [SerializeField] float loadScreenTime;

    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScreen());
        }  
    }

    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(loadScreenTime);
        SceneManager.LoadScene(currentSceneIndex+1);
    }
}
