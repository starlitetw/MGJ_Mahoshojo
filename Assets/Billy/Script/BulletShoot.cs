using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public float Speed = 1;

    private void FixedUpdate()
    {
        transform.localPosition = new Vector3(0 ,0, -Time.deltaTime * Speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "player")
        {
            Destroy(gameObject);
            Debug.Log("CO");
        }
    }
}
