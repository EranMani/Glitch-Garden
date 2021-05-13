using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    LevelLoader levelLoader;
    LevelController levelController;

    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;
    float lives;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
        levelController = FindObjectOfType<LevelController>();
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        print(lives);

        if (lives <= 0)
        {
            levelController.HandleLoseCondition();
        }
    }
}
