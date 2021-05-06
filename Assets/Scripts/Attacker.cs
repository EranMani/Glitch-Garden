using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    float currentSpeed;
    GameObject currentTarget;

    Animator anim;
    LevelController levelController;

    private void Awake()
    {
        levelController = FindObjectOfType<LevelController>();
        levelController.AttackerSpawned();
    }

    private void OnDestroy()
    {
        if (levelController != null)
        {
            levelController.AttackerKilled();
        } 
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            anim.SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget(int damage)
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }     
    }

    public void Attack(GameObject target)
    {
        anim.SetBool("isAttacking", true);
        currentTarget = target;
    }
}
