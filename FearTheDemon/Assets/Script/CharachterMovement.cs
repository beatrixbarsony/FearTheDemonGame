using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CharachterMovement : MonoBehaviour
{
    public static event Action CoinPickedUp = delegate { };
   
    private Rigidbody2D rigidBody;

    public Vector3 respawnPoint;
   
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

   
    void Update()
    {

           }
    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.tag.Equals("Coin"))
        {
            CoinPickedUp();
            Destroy(collison.gameObject);
        }
    }

}