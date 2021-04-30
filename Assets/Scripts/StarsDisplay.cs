using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starsText;

    // Start is called before the first frame update
    void Start()
    {
        starsText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starsText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendingStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }     
    }

}
