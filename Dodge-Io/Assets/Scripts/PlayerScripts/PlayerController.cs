using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float health;

    public UnityEvent UserLost;

    bool playerDieStatus = true; 
    
        
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerHealthStatus();
    }


    void CheckPlayerHealthStatus()
    {
        if(health <= 0 && playerDieStatus)
        {
            UserLost.Invoke();
            playerDieStatus = false;
        }
    }


    

}




