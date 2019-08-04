using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
    }
}
