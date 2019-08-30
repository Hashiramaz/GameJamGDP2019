using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
   public CreateObject createObject;
    public void SpawnLevel(){
            createObject.OnTriggerSpace();

    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entrou no Trigger" + other);
        if(other.CompareTag("EndOfLevel")){
        SpawnLevel();
        }
    }

  
}
