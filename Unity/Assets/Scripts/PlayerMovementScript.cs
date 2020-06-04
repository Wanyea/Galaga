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
        //TODO: Create SerializedField where data can be entered via Unity 
        playerScript.rb2d.velocity = new Vector2(-5, 0);
    }

    private void MovePlayerRight() {
        //TODO: Create SerializedField where data can be entered via Unity 
        playerScript.rb2d.velocity = new Vector2(5, 0);

    }

    private void StopMovement () {
        playerScript.rb2d.velocity = new Vector2(0, 0);
    }
}
