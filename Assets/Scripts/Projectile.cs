using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int damageAmount = 5;

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var attacker = other.GetComponent<Attacker>();
        var attackerHealth = attacker.GetComponent<Health>();

        if (attacker && attackerHealth)
        {
            attackerHealth.DealDamage(damageAmount);
            Destroy(this.gameObject);
        }    
    }
}
