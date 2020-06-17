using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//============================================
//Blaster Script - Deals with player blaster 
//============================================

public class BlasterScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody; 

    [SerializeField]
    PlayerScript playerScript;

    [SerializeField]
    Vector2 BlasterForce = new Vector2(0, 80.0f);

    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();  
      //Destroys blaster after it leaves the gamescreen.
      Invoke("DestroySelf", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = (BlasterForce);
    }

//Destroys blaster when it has collided with other entities.
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("PlayerAndEnemies"))
        {
         Destroy(gameObject);
        }
            }
    private void DestroySelf() 
    {
      Destroy(gameObject);
    }
  
}
