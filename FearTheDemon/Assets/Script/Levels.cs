using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{

    public CharachterMovement gamePlayer;
    public int coins;
    public Text coinText;
    // Use this for initialization
    void Start()
    {
        gamePlayer = FindObjectOfType<CharachterMovement>();
        coinText.text = "Coins: " + coins;
    }

    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;
        coinText.text = "Coins: " + coins;
    }
}