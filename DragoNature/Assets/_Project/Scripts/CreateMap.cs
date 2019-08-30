using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform SpawnMapPoint;
    public GameObject Plane;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    void GenerateMap(){
        Instantiate(Plane, SpawnMapPoint.position,SpawnMapPoint.rotation);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "TriggerForMap"){
            GenerateMap();
        }

        
    }
}
