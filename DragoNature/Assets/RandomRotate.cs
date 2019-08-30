using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    public float speed = 5f;
public Vector3 direction = new Vector3(0,0,0);
    protected Rigidbody m_rb;

    public Rigidbody rb{
        get{
                if(m_rb == null)
                 m_rb =  GetComponent<Rigidbody>();

                 return m_rb;
        }
    }
    private void Start() {
        GenerateRandomRotation();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Rotate();
    }

    public void Rotate(){
      
        
         transform.Rotate(direction  * Time.deltaTime * speed );

      
    }

    public void GenerateRandomRotation(){
        direction = new Vector3(Random.value,Random.value,Random.value);    }
}
