using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour, IHealth
{
    public float maxHealth;
    public float currentHealth;
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 90f;
    public float attackDamage = 5f;
    public float fireRate;

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
