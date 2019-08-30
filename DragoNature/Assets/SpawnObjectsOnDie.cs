using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsOnDie : MonoBehaviour
{
    public GameObject[] objToSpawnOnDeath;
    public void Die(){
        
        for (int i = 0; i < objToSpawnOnDeath.Length; i++)
        {
            Instantiate(objToSpawnOnDeath[i],transform.position,transform.rotation);
        }
    }
}
