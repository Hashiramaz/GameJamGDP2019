﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject[] bulletPrefabs;

    public GameObject[] bulletPoints;

    public float firingRate = 0.5f;
    public float nextTimeToFire;  

    public bool buttonFirePressed;

    public bool buttonspaceenabled;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update() {
        UpdateShooting();

    }   



    public void UpdateShooting(){
        
        if(GameManager.instance != null)
        if(!GameManager.instance.isPlaying)
            return;
            
        buttonspaceenabled = Input.GetKey(KeyCode.Space);

        if(buttonspaceenabled){

                TryShoot();

        }

        buttonFirePressed = Input.GetAxisRaw("FireTrigger") > 0.5f;
        
        if(buttonFirePressed)
            TryShoot();




    }


    public void TryShoot(){
        
        //verify if Player Have Bullets
        if(Time.time < nextTimeToFire)
                return;             
            


        //Everything is fine, shoooot!!!!
        Shoot();


    }

    public void Shoot(){
                
        
        //Debug.Log("Shooting");
        

       //Spawn Bullets for each bullets necessary
                  
        //Instantiate the Bullet Prefab
        for (int i = 0; i < bulletPoints.Length; i++)
        {
            GameObject bullet = Instantiate(bulletPrefabs[i],bulletPoints[i].transform.position, bulletPoints[i].transform.rotation);
            
        }

        //RotateBullet? // NEED REFACTORING, MAYNE WE CANT ROTATE THE BULLETS!
          //  RotateBullet(bullet);        
      
        //Set the next allowed fireTime
        nextTimeToFire = Time.time + firingRate;

        //Play Sound
        //FindObjectOfType<AudioManager>().Play("Shoot_1");
        AudioManager.instance.Play("Fire");

        //Shake Camera
         //ShakeCamera();

        //Remove Bullets from ammo 
        //actualAmmo--;

    }
}
