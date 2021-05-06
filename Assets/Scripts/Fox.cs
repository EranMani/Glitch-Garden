using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject target = other.gameObject;
        Defender defender = other.GetComponent<Defender>();
        Attacker attacker = GetComponent<Attacker>();
        Animator anim = GetComponent<Animator>();

        if (other.GetComponent<Gravestone>())
        {
            anim.SetTrigger("Jump");
        }
        else if (defender)
        {
            attacker.Attack(target);
        }
        
    }
}
