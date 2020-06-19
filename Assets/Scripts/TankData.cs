using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour, IHealth
{
    private float maxHealth;
    private float currentHealth;
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 90f;
    public float attackDamage = 5f;

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            // TODO: Die
        }
    }
}
