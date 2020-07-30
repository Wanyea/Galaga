using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//===============================================
//Main Player Script - Connects all sub scripts
//===============================================

[System.Serializable]
public class Boundary 
{
    public float xMin, xMax, yMin, yMax;
}
public class PlayerScript : MonoBehaviour 
{

    //Reference all sub player scripts 
    [SerializeField] public PlayerInputScript inputScript;
    [SerializeField] public PlayerMovementScript movementScript;
    [SerializeField] public PlayerCollisionScript collisonScript;
    [SerializeField] public BlasterScript blasterScript;
    [SerializeField] private float timeBetweenPlayerRespawn;
    public SpawnerScript spawnerScript;
    public GameplayScript gameplayScript;
    public Boundary boundary;
    public new Rigidbody2D rigidbody { get; private set; }
    public GameObject playerExplosionAnimation;
    public GameObject playerExplosionAudio;
    public GameObject playerBlasterAudio;
    public bool isPlayerHit;
    public bool needRespawn;
    public bool isGameOver;
    public int playerLives;
    
    Animator animator;
    GameObject Blaster;
    Object blasterRef;
    

void Start()
{   
    blasterRef = Resources.Load("Blaster");
    animator = GetComponent<Animator>();
    rigidbody = GetComponent<Rigidbody2D>();
    gameplayScript = GetComponent<GameplayScript>();
    spawnerScript = GetComponent<SpawnerScript>();
    needRespawn = false;
    isGameOver = false;

}

void Update() 
{
    rigidbody.position = new Vector3
    (
        Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
        Mathf.Clamp(rigidbody.position.y, boundary.yMin, boundary.yMax),
        0.0f 
    );

    if(inputScript.isShootPressed) 
    {
         GameObject Blaster = (GameObject)Instantiate(blasterRef);
         Blaster.transform.position = new Vector3(transform.position.x + 0.08f, transform.position.y + .6f, -1);
         Instantiate(playerBlasterAudio, gameObject.transform.position, Quaternion.identity);
         Destroy(playerBlasterAudio, 5.0f);
      

    }
}  


public void OnCollisionEnter2D(Collision2D collision) {
          Instantiate(playerExplosionAudio, gameObject.transform.position, Quaternion.identity);
          Destroy(playerExplosionAudio, 5.0f);
          Instantiate(playerExplosionAnimation, GameObject.FindGameObjectWithTag("Player").transform.position, Quaternion.identity);
          needRespawn = true;
          isPlayerHit = true;

    if(isPlayerHit) {
        playerLives--;
        Debug.Log("player lives = " + playerLives);

        if(playerLives == 2) {
            Debug.Log("Successfully entered playerLives == 2");
            GameObject.FindGameObjectWithTag("PlayerLife3").GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(playerRespawn());
            isPlayerHit = false;
            
        } else if(playerLives == 1) {
            GameObject.FindGameObjectWithTag("PlayerLife4").GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(playerRespawn());
            isPlayerHit = false;

        } else if(playerLives == 0) {
            isGameOver = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            GameObject.FindGameObjectWithTag("GameOverText").GetComponent<Text>().enabled = true;
            
            //SceneManager.LoadScene(currentScene.name);
            //TODO: add a delay and refresh the scene/go to title screen...
        }
    }  
}

public IEnumerator playerRespawn() {
      if(needRespawn) {
        Debug.Log("Dead");
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(timeBetweenPlayerRespawn);
        Debug.Log("Alive");
        gameObject.GetComponent<Renderer>().enabled = true;
        needRespawn = false;
      }
    }


}
