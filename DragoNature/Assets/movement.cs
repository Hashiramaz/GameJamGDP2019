using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        MoveSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        
        //print("HI IM A RASENGAN CUBE!");

        //Move only horizontal
        //transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,0f);

        //Move both directions
        transform.Translate(MoveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,MoveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);



    }
}
