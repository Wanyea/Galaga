using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//==========================================================================
//Spawner Script - Deals with spawning enemies, players and other entities
//==========================================================================
public class SpawnerScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
    public GameObject YellowWithBlueWings;
    public GameObject WhiteWithRedWings;
    public GameObject Spaceship;
    Object yellowBlueObject;
    Object whiteRedObject;
    Object spaceshipObject;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        spaceshipObject = Resources.Load("Spaceship");
        yellowBlueObject = Resources.Load("YellowWithBlueWings");
        whiteRedObject = Resources.Load("WhiteWithRedWings");

        //Spawns first spaceship at start of game. 
        spawnSpaceship();

        //Spawns first wave of enemies into the scene.
        for(int i = 0; i < 4; i++) 
        {
           GameObject yellowClone = Instantiate(YellowWithBlueWings);
           GameObject redClone = Instantiate(WhiteWithRedWings);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void spawnSpaceship() {
        Instantiate(Spaceship, new Vector3(0.001f, -6.49f, -0.01f), Quaternion.identity);
    }
}
