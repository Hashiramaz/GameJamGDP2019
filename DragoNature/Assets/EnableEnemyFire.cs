using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyFire : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Enemy"))
            other.gameObject.GetComponent<EnemyManager>().enemyWeapon.StartShoot();
    }
}
