using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (EagleScript.eagleAlive && other.gameObject.CompareTag("Player"))
        {
            EagleScript.numberOfCoins++;
            Destroy(gameObject);
        }
    }
}
