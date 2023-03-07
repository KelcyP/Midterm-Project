using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody monsterRigidbody;
    void Start()
    {
        monsterRigidbody = GetComponent<Rigidbody>();
        monsterRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 5f);
    }


    void Update()
    {
        
    }
}
