using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int HP;
    public bool[] Tags;
    public int Attack;
    public bool unbreakable;
    public Controller controller;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "Candy")
        {
            controller.ChangeWeapon(1);
        }
        if(other.name == "Apple")
        {
            HP += 30;
            Destroy(other.gameObject);
        }
        if(other.name == "Potion")
        {
            HP = 30;
        }
        if(other.name == "Axe")
        {
            Attack += 30;
        }
        if (other.name == "Star")
        {
            unbreakable = true;
            Invoke("Reset_Unbreakable", 10);
            Destroy(other.gameObject);
        }
    }

    public void Reset_Unbreakable() 
    {
        unbreakable = false; 
    }
}
