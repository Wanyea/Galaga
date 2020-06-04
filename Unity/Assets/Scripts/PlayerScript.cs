using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//===============================================
//Main Player Script - Connects all sub scripts
//===============================================

public class PlayerScript : MonoBehaviour {

    //Reference all sub player scripts 
    [SerializeField]
    internal PlayerInputScript inputScript;

    [SerializeField]
    internal PlayerMovementScript movementScript;

    [SerializeField]
    internal PlayerCollisionScript collisonScript;



// Start is called before the first frame update
void Start()
{

//anim = GetComponent<Animator>();
rb2d = GetComponent<Rigidbody2D>();

}

// Update is called once per frame
void Update() 
{

}

    }   

