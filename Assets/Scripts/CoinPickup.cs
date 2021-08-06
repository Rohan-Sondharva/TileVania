using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    // Config Params
    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] float volume = 0.2f;
    [SerializeField] int coinScore = 50;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position, volume);
        FindObjectOfType<GameSession>().AddToScore(coinScore);
        Destroy(gameObject);        
    }

}
