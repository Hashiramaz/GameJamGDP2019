using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollectable : MonoBehaviour
{
   
   private void OnTriggerEnter(Collider other) {
       if(other.CompareTag("Player")){

            other.gameObject.GetComponent<PlayerManager>().weaponHolder.LevelUp();
            other.gameObject.GetComponent<PlayerManager>().health += 1;
        Destroy(gameObject);
       }

   }
}
