using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnCollision : MonoBehaviour
{
    public float TimeToDestroyGameObject;
    public GameObject[] GOtoDesactivate;
private void OnCollisionEnter(Collision other) {
    transform.SendMessage("Die",SendMessageOptions.DontRequireReceiver);
    DesactivateGraphics();
    Destroy(gameObject,TimeToDestroyGameObject);
}
    public void DesactivateGraphics(){
        for (int i = 0; i < GOtoDesactivate.Length; i++)
        {
            GOtoDesactivate[i].SetActive(false);
        }

    }
}
