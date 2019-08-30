using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePositionOnDeath : MonoBehaviour
{    protected Rigidbody m_rb;

    public Rigidbody rb{
        get{
                if(m_rb == null)
                 m_rb =  GetComponent<Rigidbody>();

                 return m_rb;
        }
    }
   public void Die(){
       rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
   }
}
