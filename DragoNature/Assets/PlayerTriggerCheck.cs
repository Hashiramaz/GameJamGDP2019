using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerCheck : MonoBehaviour
{
  

    private void OnTriggerEnter(Collider other) {
       if(other.gameObject.CompareTag("Enemy")  || other.gameObject.CompareTag("BulletEnemy")){
           transform.root.SendMessage("TakeDamage",1);
       } 

       
    }
}
