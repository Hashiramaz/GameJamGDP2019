using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float health = 1f;
    public  bool allowDebug = true   ;

    public WeaponHolder weaponHolder;
    public EnemyFlashOnHit flashOnHit;
     
    public void TakeDamage(float amount){
        health -= amount;
        weaponHolder.LevelDown();
        if(flashOnHit != null)
            flashOnHit.StartFlash();

            
        if(health <= 0)
            PlayerDies();
    }

    public void PlayerDies(){
        GameManager.instance.StopGame();
    }
    
    
    private void OnGUI() {
        
        if(!allowDebug)
            return;
        
        GUI.Label(new Rect(10, 300, 200, 200), "Actual Life: " + health);
    }

}
