using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnDie : MonoBehaviour
{
    public void Die(){
        Destroy(gameObject,0.1f);
    }
}
