using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

//=========================================================================
//Spawner Script - Deals with spawning enemies, players and other entities
//=========================================================================
public class SpawnerScript : MonoBehaviour
{

    [SerializeField] private float timeBetweenEnemySpawn;
    public GameObject YellowWithBlueWings;
    public GameObject WhiteWithRedWings;
    public GameObject Spaceship;
    public Spline yellowSpline;
    public Spline redSpline;
    public int enemiesPerWave;
    public float explosionTime;
    public float playerExplosionTime;
    public float offScreenX, offScreenY, offScreenZ;
    public PlayerScript playerScript;
    public Transform playerSpawn;
    public Transform playerWaiting;
    

    void Start()
    {
        spawnPlayer();
        StartCoroutine(spawnWaves()); 
        
    }

    void Update() 
    {
        Destroy(GameObject.FindGameObjectWithTag("Explosions"), explosionTime);
        Destroy(GameObject.FindGameObjectWithTag("PlayerExplosion"), playerExplosionTime);

    }
  
    private IEnumerator spawnWaves() {
        for(int i = 0; i < enemiesPerWave; i++) 
        {
           GameObject yellowClone = Instantiate(YellowWithBlueWings, new Vector3(offScreenX, offScreenY, offScreenZ), Quaternion.identity);
           var enemyScript =  yellowClone.GetComponent<EnemyScript>();
           enemyScript.spline = yellowSpline;
           GameObject redClone = Instantiate(WhiteWithRedWings, new Vector3(offScreenX, offScreenY, offScreenZ), Quaternion.identity);
           enemyScript =  redClone.GetComponent<EnemyScript>();
           enemyScript.spline = redSpline;

           yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

    }
  

  public void spawnPlayer() {
    Instantiate(Spaceship);
}

}
