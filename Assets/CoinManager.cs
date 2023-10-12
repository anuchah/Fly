using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int coinCount;

    private void Update()
    {
        Debug.Log("COIN SCORE: " + coinCount);
    }
}
