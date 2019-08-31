using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
 public float health;
public bool isDead;
public EnemyWeaponRoutine enemyWeapon;




 private void OnCollisionEnter(Collision other) {
     if(other.gameObject.CompareTag("Bullet"))
        TakeDamage(other.gameObject.GetComponent<BulletBehaviour>().damage);
 }


    public void TakeDamage(float amount){
        health -= amount;
        if(health <= 0)
            Die();
    }

    public void Die(){
        if(isDead)
        return;

        isDead = true;
            transform.SendMessage("Die");
    }
}
