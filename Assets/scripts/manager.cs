using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public int score;
    public Text scoretext; 

    public void AddScore(int amount)
    {
        score = score + 1;
        scoretext.text = score.ToString();
    }
}
