using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour
{
    public TankData data;
    public GameObject shellPrefab;
    public void Shoot()
    {
        GameObject shellInstance = Instantiate(shellPrefab);
        shellInstance.GetComponent<CannonShell>().attacker = this.gameObject;
        shellInstance.GetComponent<CannonShell>().attack = new Attack(data.attackDamage);
    }
}
