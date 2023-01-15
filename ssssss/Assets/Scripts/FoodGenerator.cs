using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGenerator : MonoBehaviour
{
    public GameObject Food;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public float interval = 5;
    float timer;

    void LateUpdate()
    {

        timer += Time.deltaTime;
        if(timer >= interval)
        {
            FoodSpawn();
            timer -= interval;
        }
    }    

    void FoodSpawnRandomly()
    {
        FoodSpawn();
    }

    void FoodSpawn()
    {
         Vector3 randomPosition = new Vector3(
         Random.Range(minPosition.x, maxPosition.x),
         Random.Range(minPosition.y, maxPosition.y),
         Random.Range(minPosition.z, maxPosition.z)
         );

         GameObject instanceObject = Instantiate(Food, randomPosition, Quaternion.identity) as GameObject;
         

    }
}
