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

  
}