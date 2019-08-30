using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyInSeconds : MonoBehaviour
{
   public float timeToDestroy;

private void Start() {
    
StartCoroutine(AutoDestroyIn(timeToDestroy));
}



   IEnumerator AutoDestroyIn(float _time){
       yield return new WaitForSeconds(_time);
       transform.SendMessage("Die");
       Destroy(gameObject);
   }
}
