using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsOnDie : MonoBehaviour
{
    public GameObject[] objToSpawnOnDeath;
        Transform rootTransform;
    public void Die(){
        if(transform.root != transform){
            rootTransform = transform.root;
        }
        for (int i = 0; i < objToSpawnOnDeath.Length; i++)
        {
            GameObject go = Instantiate(objToSpawnOnDeath[i],transform.position,transform.rotation);
            if(rootTransform != null)
                go.transform.SetParent(rootTransform);
        }
    }
}
