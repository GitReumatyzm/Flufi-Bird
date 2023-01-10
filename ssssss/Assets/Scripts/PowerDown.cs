using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown : MonoBehaviour
{
    public float multiplier = 1.4f;

    public GameObject pickupEffect;

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        //1
        Instantiate(pickupEffect, transform.position, transform.rotation);
        //2
        player.transform.localScale *= multiplier;
        Physics.gravity = new Vector3(0, -45, 0);
        //3
        Destroy(gameObject);
    }
}
