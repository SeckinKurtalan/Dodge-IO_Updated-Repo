using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatusController : MonoBehaviour
{

    [SerializeField] PlayerMovement playerJoystickDisablerScript;

    [SerializeField] GameObject JoyStick;

    [SerializeField] GameObject GameOverPanel;

    [SerializeField] GameObject LevelPassedPannel;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StopTheGameInPlayerDies()
    {
        playerJoystickDisablerScript.speed = 0;
        JoyStick.SetActive(false);
        GameOverPanel.SetActive(true);
        GameOverPanel.GetComponent<Animator>().Play("BarDown");
    }


    public void StopTheGameInPlayeWins()
    {
        playerJoystickDisablerScript.speed = 0;
        JoyStick.SetActive(false);
        LevelPassedPannel.SetActive(true);
        LevelPassedPannel.GetComponent<Animator>().Play("BarDown");
    }

}
