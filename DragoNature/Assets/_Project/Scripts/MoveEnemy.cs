using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = -2f;
    public bool canMove;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEnemyMovement();
    }

    public void UpdateEnemyMovement(){

        if(!canMove)
        return;

        transform.Translate(0f,0f,moveSpeed*Time.deltaTime);
    }

    public void StartMove(){
        canMove = true;
    }
}
