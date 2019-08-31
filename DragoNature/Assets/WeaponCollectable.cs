using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollectable : MonoBehaviour
{
   public bool isDead;
   private void OnTriggerEnter(Collider other) {


       if(other.CompareTag("Player")){
           
            other.gameObject.GetComponent<PlayerManager>().weaponHolder.LevelUp();
            other.gameObject.GetComponent<PlayerManager>().health += 1;
        transform.SendMessage("Die");
        Destroy(gameObject);
       }

   }
}
