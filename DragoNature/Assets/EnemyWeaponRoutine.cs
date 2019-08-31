using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponRoutine : MonoBehaviour
{
public Transform bulletpoint;
public GameObject bulletprefab;

public ParticleSystem muzzleFlash;

public bool canShoot;

public float firingRate = 0.5f;

private void Start() {
   // StartShoot();
}
public void StartShoot(){
    if(canShoot)
        return;
        
canShoot = true;
StartCoroutine(WeaponRoutine());
}

public void StopShoot(){
    canShoot = false;
}


    IEnumerator WeaponRoutine(){
        while (canShoot)
        {
            
            yield return new WaitForSeconds(firingRate);
            Shoot();
        }
            
        
    }

    public void Shoot(){
        Instantiate(bulletprefab,bulletpoint.position,bulletpoint.rotation);
        
        if(muzzleFlash != null)
            muzzleFlash.Play();
    }
}
