using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] GameObject deathEffect;

    public void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (deathEffect)
            {
                GameObject effect = Instantiate(deathEffect, transform.position, transform.rotation);
                Destroy(effect, 2f);
            }
            
            Destroy(this.gameObject);
        }
    }
}
