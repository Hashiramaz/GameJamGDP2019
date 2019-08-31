using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlashOnHit : MonoBehaviour
{
    //	private Dictionary<Renderer, Material[]> originalMaterials = new Dictionary<Renderer, Material[]>();

	//public Renderer[] children;
    // Start is called before the first frame update
    public SkinnedMeshRenderer meshRenderer;
    
    public Material WhiteMaterial;
    private Material AuxMaterial;
    private Material AuxMaterial2;
    private float Temporizer;
    
    
    void Start()
    {
        
        AuxMaterial = meshRenderer.materials[0];
        AuxMaterial2 = meshRenderer.materials[1];
        Temporizer = 0;

        
    }

    private void Awake() {
               //children is a reference to the renderers
        //  children = GetComponentsInChildren<Renderer>();
 
        //  foreach (Renderer rend in children)
        //  {
        //      //make array of all materials in renderer
        //      Material[] materials = rend.materials;
        //      //add to dictionary renderer and material
        //      originalMaterials[rend] = materials;
        //  }
    }

    // Update is called once per frame
    void Update()
    {   
        
        //  if(Input.GetKeyDown("space")){
        //      StartCoroutine(flashRoutine());
        //  }
    }

    //void EnemyFlash(status){    
        //meshRenderer.material = status;


    //}

    public void StartFlash(){
        StartCoroutine(flashRoutine());
    }
    void EnemyFlashing(){
        meshRenderer.materials = new Material[]{WhiteMaterial, WhiteMaterial};
    }
    IEnumerator flashRoutine(){
        EnemyFlashing();
        yield return new WaitForSeconds(0.1f);
        EnemyBack();

    }

    void EnemyBack(){
        //meshRenderer.materials.SetValue(AuxMaterial,1);
        meshRenderer.materials = new Material[]{AuxMaterial, AuxMaterial2};
    }


	// public IEnumerator StartFlashDamage(){
		 
	// 	 foreach (Renderer rend in children)
    //      {
    //          var mats = new Material[rend.materials.Length];
    //          for (var j = 0; j < rend.materials.Length; j++)
    //          {
    //              mats[j] = damagedMaterial;
    //          }
    //          rend.materials = mats;
    //      }

	// 	yield return new WaitForSeconds(flashDuration);
	// 	ResetMaterial();

	// }

 	// void ResetMaterial()
    //  {
 
    //      foreach (KeyValuePair<Renderer, Material[]> pair in originalMaterials)
    //      {
             
    //          pair.Key.materials = pair.Value;
                 
    //      }
    //  }

}
