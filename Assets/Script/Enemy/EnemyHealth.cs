using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;

    public GameObject blueSlime;
    public GameObject arrowPouch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GameObject newArrow = Instantiate(arrowPouch, transform.position, transform.rotation);
            if(gameObject.tag == "Boss")
            {
                GameObject newEnemy = Instantiate(blueSlime, transform.position, transform.rotation);
                Destroy(gameObject);
                //debug.log("boss is dead new slime created");
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
