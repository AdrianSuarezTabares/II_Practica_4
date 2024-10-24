using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCollision : MonoBehaviour
{
    public int points; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = other.GetComponent<ScoreManager>();
            scoreManager.AddScore(points); 

            Destroy(gameObject); 
        }
    }
}
