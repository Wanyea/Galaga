using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//===========================================================================
//Gameplay Script - Deals gameplay elements not handled by individual assets
//===========================================================================

public class GameplayScript : MonoBehaviour
{
    //private Scene currentScene;
    public SpawnerScript spawnerScript;
    public PlayerScript playerScript;
    public GameObject PlayerLife2;
    public GameObject PlayerLife3;
    public GameObject PlayerLife4;
    public Text gameOverText;
    public Text waveNumberText;
    public float respawnTime;


    
public IEnumerator Start() 
{
    spawnerScript = GetComponent<SpawnerScript>();
    playerScript = GetComponent<PlayerScript>();
    GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>().enabled = false;
    waveNumberText.GetComponent<Text>().enabled = true;

    //currentScene = SceneManager.GetActiveScene();
    
    yield return new WaitForSeconds(spawnerScript.beforeGameAudioDuration);
     waveNumberText.GetComponent<Text>().enabled = false;
    PlayerLife2.GetComponent<SpriteRenderer>().enabled = false;
    PlayerLife3.GetComponent<SpriteRenderer>().enabled = true;
    PlayerLife4.GetComponent<SpriteRenderer>().enabled = true;

   
}

void Update() 
{

}


}
