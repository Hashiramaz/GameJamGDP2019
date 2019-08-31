using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float MoveSpeed = 7f;
    public Animator animator;

    public bool movingLeft;
    public bool movingRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //print("HI IM A RASENGAN CUBE!");

        //Move only horizontal
        //transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,0f);
        
        //Move both directions
        transform.Translate(MoveSpeed*Input.GetAxisRaw("Horizontal")*Time.deltaTime,0f,MoveSpeed*Input.GetAxisRaw("Vertical")*Time.deltaTime);
        animator.SetFloat("Rotation",Input.GetAxis("Horizontal"));
    
        



    //     if(Input.GetKey("Left")){
    //         AnimationMoveLeft();
    //         }
    //     if(Input.GetKey("Right")){
    //         AnimationMoveRight();
    //     }

    

    

    // }
    // void AnimationMoveLeft(){
    //     transform.Rotate(10,0,0,Space.Self);

    // }

    // void AnimationMoveRight(){

    // }


}
}
