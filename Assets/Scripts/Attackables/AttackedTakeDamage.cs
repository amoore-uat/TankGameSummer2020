using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackedTakeDamage : MonoBehaviour, IAttackable
{
    private IHealth healthData;

    private void Start() 
    {
        healthData = GetComponent<IHealth>();
        if (healthData == null)
        {
            Debug.LogError("[AttackedTakeDamage] Game object has no IHealth component.");
        }
    }
    public void OnAttack(GameObject attacker, Attack attack)
    {
        healthData.TakeDamage(attack.Damage);
    }
}
