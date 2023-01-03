using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FoodScore : MonoBehaviour
{
    public Text FoodScoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        FoodScoreText.text = "Food Score : " + ScoreNum;
    }
    
    private void OnTriggerEnter2D(Collider2D Food)
    {
       if (Food.tag == "MyFood")
       {
         ScoreNum += 1;
         Destroy(Food.gameObject);
         FoodScoreText.text = "Food Score: " + ScoreNum;
       }
    }
}