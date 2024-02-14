using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            Destroy(gameObject);  
        }
    }
}
