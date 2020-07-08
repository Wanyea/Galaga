using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//===============================================
//Main Player Script - Connects all sub scripts
//===============================================

public class PlayerScript : MonoBehaviour 
{

    //Reference all sub player scripts 
    [SerializeField]
    public PlayerInputScript inputScript;

    [SerializeField]
    public PlayerMovementScript movementScript;

    [SerializeField]
    public PlayerCollisionScript collisonScript;

    [SerializeField]
    public BlasterScript blasterScript;

    public new Rigidbody2D rigidbody { get; private set; }
    Animator animator;
    GameObject Blaster;
    Object blasterRef;

// Start is called before the first frame update
void Start()
{   
    blasterRef = Resources.Load("Blaster");
    animator = GetComponent<Animator>();
    rigidbody = GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update() 
{
    if(inputScript.isShootPressed) 
    {

    GameObject Blaster = (GameObject)Instantiate(blasterRef);
    Blaster.transform.position = new Vector3(transform.position.x + 0.08f, transform.position.y + .6f, -1);

    }
}  

}
