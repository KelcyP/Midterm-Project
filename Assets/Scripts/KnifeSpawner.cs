using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    public GameObject knifePrefab;

    private Transform target;

    void Start()
    {
        
        
    }

    void Update()
    {

    }

    public void shootKnife()
    {
        KnifeMove km = FindObjectOfType<KnifeMove>();
        PumpkinMove pm = FindObjectOfType<PumpkinMove>();
        target = pm.transform;

        if (!km)
        {
            GameObject knife = Instantiate(knifePrefab, transform.position, transform.rotation);
            knife.transform.LookAt(target);
        }
    }
}
