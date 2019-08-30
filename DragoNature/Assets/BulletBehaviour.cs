using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 20f;

    public float damage = 100f;
    public Rigidbody rb{
        get{
            if(m_rb == null)
                m_rb = GetComponent<Rigidbody>();
                return m_rb;
        }
    }
    protected Rigidbody m_rb;

    private void Start() {
        rb.velocity = transform.forward * speed;     
    }
}
