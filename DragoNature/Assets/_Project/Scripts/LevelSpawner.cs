using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public List<GameObject> listOfLevels;
    public GameObject levelToSpawn;
    public GameObject clouds;
    public Transform spawnpoint;

    public int actualLevelIndex;
    private void Start() {
        SelectLevel(0);
    }
    public void SpawnLevel(){
          
            Instantiate(levelToSpawn,spawnpoint.position,spawnpoint.rotation);
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entrou no Trigger" + other);
        if(other.CompareTag("EndOfLevel")){
             SpawnLevel();
             
             UpgradeLevel();
        }
    }


    public void UpgradeLevel(){
        SelectLevel(actualLevelIndex +1);
    }

    public void SelectLevel(int index){
        if(index < listOfLevels.Count)
            actualLevelIndex = index;
        
        levelToSpawn =listOfLevels[actualLevelIndex]; 
    }

  
}
