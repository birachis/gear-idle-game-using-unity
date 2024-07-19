using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public Text score;
    public float rate = 2;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
        {
            
        }
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn();
        }
       
        
    }
     public void spawn()
    {
        GameObject obstacle = obstacle1;
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                obstacle = obstacle1;
                break;
            case 1:
                obstacle = obstacle2;
                break;
            case 2:
                obstacle = obstacle3;
                break;
            case 3:
                obstacle = obstacle4;
                break;
            
            default:
                obstacle = obstacle1;
                break;
        }
        float rot = Random.Range(0, 360);
        Instantiate(obstacle, transform.position, Quaternion.Euler(0, 0, rot));
        timer = 0;
        if (int.Parse(score.text) > 5 && rate > 1)
        {
            rate -= 0.2f;
        }
    }
} 
