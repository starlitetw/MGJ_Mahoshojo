﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public float Speed = 1;

    private void FixedUpdate()
    {
        transform.localPosition = new Vector3(0 ,0, -gameObject.transform.position.z + (Time.deltaTime*Speed));
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
