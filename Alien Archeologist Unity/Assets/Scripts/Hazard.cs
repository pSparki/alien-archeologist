using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public int hazardDamage = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        
        if (player != null)
        {
            player.ChangeHealth(-hazardDamage);
        }
    }
}
