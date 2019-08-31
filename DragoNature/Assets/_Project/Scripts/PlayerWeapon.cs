﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform bulletPoint;

    public float firingRate = 0.5f;
    public float nextTimeToFire;  

    public bool buttonShootingIsPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update() {
        UpdateShooting();

    }   



    public void UpdateShooting(){
        if(Input.GetKeyDown(KeyCode.Space)){

            
                TryShoot();
            

        }

        buttonShootingIsPressed = (Input.GetAxis("FireTrigger") > 0.5);

        if(buttonShootingIsPressed){

                TryShoot();

        }

    }


    public void TryShoot(){
        
        //verify if Player can Fire
        if(Time.time < nextTimeToFire)
            return;


        //Everything is fine, shoooot!!!!
        Shoot();


    }

    public void Shoot(){
                
        
        //Debug.Log("Shooting");
        

       //Spawn Bullets for each bullets necessary
                  
        //Instantiate the Bullet Prefab
        GameObject bullet = Instantiate(bulletPrefab,bulletPoint.position, bulletPoint.rotation);

        //RotateBullet? // NEED REFACTORING, MAYNE WE CANT ROTATE THE BULLETS!
          //  RotateBullet(bullet);        
      
        //Set the next allowed fireTime
        nextTimeToFire = Time.time + firingRate;

        //Play Sound
        //FindObjectOfType<AudioManager>().Play("Shoot_1");


        //Shake Camera
         //ShakeCamera();

        //Remove Bullets from ammo 
        //actualAmmo--;

    }
}
