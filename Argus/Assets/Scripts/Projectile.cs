using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 15);
        rb.AddForce(transform.up * 9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
