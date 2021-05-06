﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    LevelLoader levelLoader;

    [SerializeField] int lives = 5;
    [SerializeField] int damage = 1;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
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
            print("GAME OVER!");
            levelLoader.GameOver();
        }
    }
}