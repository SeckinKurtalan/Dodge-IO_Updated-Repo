using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAction : MonoBehaviour
{
    public PlayerController player;
    public bool GameOverStatus = false;
    public bool hitStatus = false;
    private bool controllerActive = false;


    private void Update()
    {
    }


    private void OnTriggerEnter(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("HitZone'a girildi");
            StartCoroutine("DamagePerSecond");// Player alana girdikten 1 saniye sonra hasar yiyecek ve her 1 saniyede bir yemeye devam edecek durduðu süre boyunca
        }

    }
    
    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            StopCoroutine("DamagePerSecond");
        }
    }


    void GameOverCheck() // Gameover playerýn caný 0a düþtüðünde olacak.
    {
        if ( player.health <= 0)
        {
            GameOverStatus = true;
        }

    }


    void DamageToPlayer()
    {
        Debug.Log("Damage atýldý.");
        player.health -= 25;
    }

    IEnumerator DamagePerSecond()
    {
        yield return new WaitForSeconds(1f);   //animasyonun uzunluðuna göre bekleme süresine ilerde ayar çekebiliriz.
        DamageToPlayer();
        yield return new WaitForSeconds(1f);
    }




}
