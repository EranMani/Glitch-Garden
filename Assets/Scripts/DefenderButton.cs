using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    // This will set the defender object based on player UI selection
    // It will highlight the UI element in white and will assign the relative object in the defender spawner script

    [SerializeField] Defender defenderPrefab;

    SpriteRenderer spriteRenderer;
    DefenderButton[] defenderButtons;
    DefenderSpawner defenderSpawner;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defenderButtons = FindObjectsOfType<DefenderButton>();
        defenderSpawner = FindObjectOfType<DefenderSpawner>();

        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text cost = GetComponentInChildren<Text>();
        if (!cost)
        {
            Debug.LogError(name + " has no cost text, add some!");
        }
        else
        {
            cost.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        foreach (DefenderButton button in defenderButtons)
        {
            button.spriteRenderer.color = new Color32(41, 41, 41,255);
        }

        spriteRenderer.color = Color.white;
        defenderSpawner.SetSelectedDefender(defenderPrefab);
    }
}
