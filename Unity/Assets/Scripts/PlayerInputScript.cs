using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//=================================================
//Player Input Script - Deals with player inputs
//=================================================

public class PlayerInputScript : MonoBehaviour
{
    //Reference to main player script
    [SerializeField]
    PlayerScript playerScript;

    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isShootPressed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey("left")) {
            isLeftPressed = true;

        } else {
            isLeftPressed = false;

        }
        
           if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            isRightPressed = true;

        } else {
            isRightPressed = false;

        }

        if(Input.GetKeyDown("space") || Input.GetButtonDown("Fire1")) {
            isShootPressed = true;

        } else {

            isShootPressed = false;
        }
    }
}
