using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlashOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    public SkinnedMeshRenderer meshRenderer;
    
    public Material WhiteMaterial;
    private Material AuxMaterial;
    private float Temporizer;
    
    
    void Start()
    {
        AuxMaterial = meshRenderer.material;
        Temporizer = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        
        if(Input.GetKeyDown("space")){
            StartCoroutine(flashRoutine());
        }
    }

    //void EnemyFlash(status){    
        //meshRenderer.material = status;


    //}
    void EnemyFlashing(){
        meshRenderer.material = WhiteMaterial;
    }
    IEnumerator flashRoutine(){
        EnemyFlashing();
        yield return new WaitForSeconds(0.1f);
        EnemyBack();

    }

    void EnemyBack(){
        meshRenderer.material = AuxMaterial;
    }

}
