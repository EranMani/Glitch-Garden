using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void SpawnDefender(Vector2 mousePosition)
    {
        Instantiate(defender, mousePosition, Quaternion.identity);
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }
}
