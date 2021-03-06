﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//============================================
//Blaster Script - Deals with player blaster 
//============================================

public class BlasterScript : MonoBehaviour
{
    private Rigidbody2D rigidbody; 
    private BoxCollider2D boxCollider;

    [SerializeField]
    PlayerScript playerScript;

    [SerializeField]
    Vector2 BlasterForce = new Vector2(0, 80.0f);

    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();  

      //Destroys blaster after it leaves the gamescreen.
      Invoke("DestroySelf", 2.0f);

    }

    void Update()
    {
        rigidbody.velocity = BlasterForce;
    }

//Destroys blaster when it has collided with other entities.
    private void OnCollisionEnter2D(Collision2D collision) {
        if(
           collision.gameObject.CompareTag("redEnemy") || 
           collision.gameObject.CompareTag("yellowEnemy")
          ) {
          Destroy(gameObject);
        }
            }
    private void DestroySelf() 
    {
      Destroy(gameObject);
    }
  
}
