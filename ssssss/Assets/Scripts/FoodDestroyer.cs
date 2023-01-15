using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroyer: MonoBehaviour
{
    public float Speed = 5f;
    private float LeftEdge;
    
    void Start () {

        LeftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    
    void Update () 
    {
         transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < LeftEdge) 
        {
            Destroy(gameObject);
        }
    }
}

