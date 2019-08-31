using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class EnemyManager : MonoBehaviour
{
 public float health;
public bool isDead;
public EnemyWeaponRoutine enemyWeapon;
public EnemyFlashOnHit enemyFlash;



 private void OnCollisionEnter(Collision other) {
     if(other.gameObject.CompareTag("Bullet"))
        TakeDamage(other.gameObject.GetComponent<BulletBehaviour>().damage);
 }


    public void TakeDamage(float amount){
        health -= amount;

        if(enemyFlash != null)
            enemyFlash.StartFlash();

        if(health <= 0)
            Die();
    }

    public void Die(){
        if(isDead)
        return;

        AudioManager.instance.Play("EnemyDead");

        CameraShaker.Instance.ShakeOnce(1f,1f,0.1f,0.1f);
        isDead = true;
            transform.SendMessage("Die");
    }
}
