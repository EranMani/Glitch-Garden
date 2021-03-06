using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    LivesDisplay livesDisplay;

    private void Start()
    {
        livesDisplay = FindObjectOfType<LivesDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        livesDisplay.TakeLife();
    }
}
