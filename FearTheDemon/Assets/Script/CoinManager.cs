using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    private TextMeshProUGUI scoreCounterText;
 
    private Levels gameLevelManager;
    public int coinValue;

    void Start()
    {
        gameLevelManager = FindObjectOfType<Levels>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);
        }
    }
}