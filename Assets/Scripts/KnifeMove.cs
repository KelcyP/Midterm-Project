using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMove : MonoBehaviour
{
    float speed = 30f;
    Rigidbody knifeRigidbody;

    void Start()
    {
        knifeRigidbody = GetComponent<Rigidbody>();
        knifeRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 1f);
    }


    void Update()
    {
        
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
