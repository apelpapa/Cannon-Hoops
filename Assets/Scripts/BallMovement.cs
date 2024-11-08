using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float ballForce = 2000.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(transform.forward * ballForce);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0){
            Destroy(gameObject);
        }
    }
}
