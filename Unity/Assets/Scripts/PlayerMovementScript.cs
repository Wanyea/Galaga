using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//===============================================================
//Player Movement Script - Deals with the movement of the player
//===============================================================

public class PlayerMovementScript : MonoBehaviour
{
    //Reference to main player script
    [SerializeField]
    PlayerScript playerScript = null;

    [SerializeField]
    Vector2 MoveLeftAmount = new Vector2(-5.0f, 0.0f);

    [SerializeField]
    Vector2 MoveRightAmount = new Vector2(5.0f, 0.0f); 


    // Update is called once per frame
    void Update()
    {
        //Checks from player input script to initiate movement. 
        if(playerScript.inputScript.isLeftPressed) 
        {
            MovePlayerLeft();

        } else if (playerScript.inputScript.isRightPressed) {
            
            MovePlayerRight();

        } else {

            StopMovement();
        }
        
    }

    private void MovePlayerLeft() {
        playerScript.rigidbody.velocity = MoveLeftAmount;
    }

    private void MovePlayerRight() {
        playerScript.rigidbody.velocity = MoveRightAmount;

    }

    private void StopMovement () {
        playerScript.rigidbody.velocity = new Vector2(0, 0);
    }
}
