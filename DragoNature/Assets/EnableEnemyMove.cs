using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyMove : MonoBehaviour
{
     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Enemy"))
            other.gameObject.GetComponent<MoveEnemy>().StartMove();
    }
}
