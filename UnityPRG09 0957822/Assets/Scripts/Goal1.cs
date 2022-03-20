using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Enemy1")
        {
            Debug.Log("Hit the goal");
            Scoreboard.totalScore += 1;
        }
        if(collision.transform.name == "Enemy2")
        {
            Debug.Log("Hit the goal");
            Scoreboard.totalScore += 2;
        }
        if(collision.transform.name == "Enemy3")
        {
            Debug.Log("Hit the goal");
            Scoreboard.totalScore += 2;
        }
    }
}
