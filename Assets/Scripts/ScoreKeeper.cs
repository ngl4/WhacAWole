using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score; 
    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log(score);
    }


}
