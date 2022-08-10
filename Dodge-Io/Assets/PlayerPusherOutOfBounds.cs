using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPusherOutOfBounds : MonoBehaviour
{

    [SerializeField] Rigidbody playerRB;

    bool isInbounds = false;

    [SerializeField] float pushPower;

    [SerializeField] GameObject player;
    
    
    [SerializeField] int pushPowerUp;
    
    void Start()
    {
        InvokeRepeating("InvokePushing", 0f, 0.3f);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            isInbounds = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            isInbounds = false;
        }
    }


    void InvokePushing()
    {
        var direction = -player.transform.forward;
        
        if (isInbounds)
        {
            playerRB.AddForce(direction * pushPower);
            playerRB.AddForce(Vector3.up * pushPowerUp);
            
        }
    }
}
