using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public float Speed = 1;

    void Update()
    {
        transform.Translate(transform.forward * Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log("CO");
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Tr");
    }
}
