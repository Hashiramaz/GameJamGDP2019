using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawnpoint;
    public GameObject Enemy;

    private void Update() {
        if(Input.GetKeyDown("space")){
        OnTriggerSpace();
        }
        
    }
    void OnTriggerSpace()
    {
            Instantiate(Enemy, spawnpoint.position,spawnpoint.rotation);
    }
}