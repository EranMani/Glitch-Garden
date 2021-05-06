using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject target = other.gameObject;
        Defender defender = other.GetComponent<Defender>();
        Attacker attacker = GetComponent<Attacker>();

        if (defender)
        {
            attacker.Attack(target);
        }
    }
}
