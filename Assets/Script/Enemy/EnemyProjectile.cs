using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //ignore layer water
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 5);
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Slime Projectile"), LayerMask.NameToLayer("Water"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Slime Projectile"), LayerMask.NameToLayer("Slime Projectile"));

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
