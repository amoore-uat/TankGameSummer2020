using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShell : MonoBehaviour
{
    public Attack attack;
    public GameObject attacker;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IAttackable>() != null)
        {
            IAttackable[] attackables = collision.gameObject.GetComponentsInChildren<IAttackable>();

            foreach(IAttackable attackable in attackables)
            {
                attackable.OnAttack(attacker, attack);
            }
        }
    }
}
