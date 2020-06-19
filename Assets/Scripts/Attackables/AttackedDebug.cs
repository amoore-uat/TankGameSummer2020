using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackedDebug : MonoBehaviour, IAttackable
{
    public void OnAttack(GameObject attacker, Attack attack)
    {
        Debug.LogFormat("{0} attacked {1} for {2} damage", attacker.name, name, attack.Damage);
    }
}
