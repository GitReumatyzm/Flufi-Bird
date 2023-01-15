using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown : MonoBehaviour
{
    public float multiplier = 1.4f;

    public GameObject pickupEffect;
    public AudioSource Collecting;

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        player.transform.localScale *= multiplier;
        Physics.gravity = new Vector3(0, -45, 0);
        Collecting.Play();
        Destroy(gameObject);
    }
}
