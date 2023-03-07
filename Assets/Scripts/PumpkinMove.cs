using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMove : MonoBehaviour
{
    float speed = 2.5f;
    Rigidbody pumpkinRigidbody;

    public GameObject Candy1;
    public GameObject Candy2;

    void Start()
    {
        pumpkinRigidbody = GetComponent<Rigidbody>();
        pumpkinRigidbody.velocity = -(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Finish")
        {
            GameObject candy1 = Instantiate(Candy1, transform.position, transform.rotation);
            GameObject candy2 = Instantiate(Candy1, transform.position, transform.rotation);
            GameObject candy3 = Instantiate(Candy1, transform.position, transform.rotation);
            GameObject candy4 = Instantiate(Candy1, transform.position, transform.rotation);
            GameObject candy5 = Instantiate(Candy1, transform.position, transform.rotation);
            GameObject candy6 = Instantiate(Candy2, transform.position, transform.rotation);
            GameObject candy7 = Instantiate(Candy2, transform.position, transform.rotation);
            GameObject candy8 = Instantiate(Candy2, transform.position, transform.rotation);
            GameObject candy9 = Instantiate(Candy2, transform.position, transform.rotation);
            GameObject candy10 = Instantiate(Candy2, transform.position, transform.rotation);

            KnifeMove kMove = FindObjectOfType<KnifeMove>();
            kMove.Die();
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }

    public void Highlight()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void SpawnKnife()
    {
            KnifeSpawner kSpawner = FindObjectOfType<KnifeSpawner>();
            kSpawner.shootKnife();
    }
}
