using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject levelToSpawn;
    public GameObject clouds;
    public Transform spawnpoint;
    public void SpawnLevel(){
          
            Instantiate(levelToSpawn,spawnpoint.position,spawnpoint.rotation);
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entrou no Trigger" + other);
        if(other.CompareTag("EndOfLevel")){
             SpawnLevel();
        }
    }

  
}
