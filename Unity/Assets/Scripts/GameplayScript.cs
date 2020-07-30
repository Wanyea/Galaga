using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//===========================================================================
//Gameplay Script - Deals gameplay elements not handled by individual assets
//===========================================================================

public class GameplayScript : MonoBehaviour
{
    public SpawnerScript spawnerScript;
    public GameObject PlayerLife2;
    public GameObject PlayerLife3;
    public GameObject PlayerLife4;
    public Text gameOverText;
    public float respawnTime;


    
void Start() 
{
    spawnerScript = GetComponent<SpawnerScript>();
    gameOverText = GetComponent<Text>();

    
    PlayerLife2.GetComponent<SpriteRenderer>().enabled = false;
    PlayerLife3.GetComponent<SpriteRenderer>().enabled = true;
    PlayerLife4.GetComponent<SpriteRenderer>().enabled = true;

   
}

void Update() 
{

}


}
