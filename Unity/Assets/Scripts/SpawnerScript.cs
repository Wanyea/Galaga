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
    public EnemyMovementScript enemyMovementScript;
    public GameObject YellowWithBlueWings;
    public GameObject WhiteWithRedWings;
    public GameObject YellowWithGreenWings;
    public GameObject beforeGameAudio;
    public GameObject formation;
    public GameObject Spaceship;
    public Spline yellowSpline;
    public Spline redSpline;
    public Spline greenSpline;
    public int redYellowEnemiesPerWave;
    public int greenEnemiesPerWave;
    public float explosionTime;
    public float nextGroup;
    public float beforeGameAudioDuration;
    public float playerExplosionTime;
    public float offScreenX, offScreenY, offScreenZ;
    public PlayerScript playerScript;
    public Transform playerSpawn;
    public Transform playerWaiting;
    

  public IEnumerator Start()
    {

        enemyMovementScript = GetComponent<EnemyMovementScript>();
        Instantiate(beforeGameAudio, gameObject.transform.position, Quaternion.identity);
        Destroy(beforeGameAudio, 8.0f);
            yield return new WaitForSeconds(beforeGameAudioDuration);
            spawnPlayer();
            StartCoroutine(spawnWaves()); 
        
    }

    void Update() 
    {
        Destroy(GameObject.FindGameObjectWithTag("Explosions"), explosionTime);
        Destroy(GameObject.FindGameObjectWithTag("PlayerExplosion"), playerExplosionTime);

    }
  
    private IEnumerator spawnWaves() {
        for(int i = 0; i < redYellowEnemiesPerWave; i++) 
        {
           GameObject yellowClone = Instantiate(YellowWithBlueWings, new Vector3(offScreenX, offScreenY, offScreenZ), Quaternion.identity);
           var enemyScript =  yellowClone.GetComponent<EnemyScript>();
           enemyScript.spline = yellowSpline;
           GameObject redClone = Instantiate(WhiteWithRedWings, new Vector3(offScreenX, offScreenY, offScreenZ), Quaternion.identity);
           enemyScript =  redClone.GetComponent<EnemyScript>();
           enemyScript.spline = redSpline;

           yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

        yield return new WaitForSeconds(nextGroup);

        for(int j = 0; j < greenEnemiesPerWave; j++) 
        {
          GameObject greenClone = Instantiate(YellowWithGreenWings, new Vector3(offScreenX, offScreenY, offScreenZ), Quaternion.identity);
          var enemyScript = greenClone.GetComponent<EnemyScript>();
          enemyScript.spline = greenSpline;

          yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }



    }
  

  public void spawnPlayer() 
  {
    
    Instantiate(Spaceship);

  }
   
}
