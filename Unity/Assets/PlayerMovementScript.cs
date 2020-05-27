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
    PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check input manager for button pressed.
        if(playerScript.inputScript.isRightPressed) 
        {
            MovePlayerRight();

        } else if (playerScript.inputScript.isLeftPressed) {

            MovePlayerLeft();

        } else {
            
            StopMovement();
        }
    }

    public void MovePlayerLeft() {
        playerScript.rb2d.velocity = new Vector2(-3, 0);
    }

    public void MovePlayerRight() {
        playerScript.rb2d.velocity = new Vector2(3, 0);
    }

    public void StopMovement() {
        playerScript.rb2d.velocity = new Vector2(0, 0);
    }






}
