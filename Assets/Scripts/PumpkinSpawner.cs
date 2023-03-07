using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinSpawner : MonoBehaviour
{
    public GameObject pumpkinPrefab;

    void Start()
    {

    }

    void Update()
    {
        PumpkinMove pm = FindObjectOfType<PumpkinMove>();
        if (!pm)
        {
            GameObject pumpkin = Instantiate(pumpkinPrefab, transform.position, pumpkinPrefab.transform.rotation);
        }
    }
}
