using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform SpawnPoint;
    public GameObject Enemy;

    private void Update() {
        if(Input.GetKeyDown("space")){
        OnTriggerSpace();
        }
        
    }
    void OnTriggerSpace()
    {
            Instantiate(Enemy, SpawnPoint.position,SpawnPoint.rotation);
    }
}