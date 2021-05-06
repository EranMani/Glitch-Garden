using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level timer in SECONDS")]
    [SerializeField] float levelTime = 10;
    Slider slider;
    bool triggeredLevelFinished = false;
    LevelController levelController;

    private void Start()
    {
        slider = GetComponent<Slider>();
        levelController = FindObjectOfType<LevelController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }
 
        slider.value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            levelController.LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
