using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    public List<PlayerWeapon> weapons;

    public PlayerWeapon activeweapon;


    private void Update() {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            SelectWeapon(0);

        if(Input.GetKeyDown(KeyCode.Alpha2))
            SelectWeapon(1);
        
        if(Input.GetKeyDown(KeyCode.Alpha3))
            SelectWeapon(2);
        if(Input.GetKeyDown(KeyCode.Alpha4))
            SelectWeapon(3);
        
    }
    private void Start() {
        SelectWeapon(0);
    }
    public void SelectWeapon(int index){
        Debug.Log("Selecting Weapon: " + index);
    for (int i = 0; i < weapons.Count; i++)
    {
            weapons[i].gameObject.SetActive(false);
            
            if(i== index){
                activeweapon = weapons[index];
                weapons[i].gameObject.SetActive(true);
            }

    }
    
    
    }



}
