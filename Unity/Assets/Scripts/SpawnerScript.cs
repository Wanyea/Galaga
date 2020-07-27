using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

//=========================================================================
//Spawner Script - Deals with spawning enemies, players and other entities
//=========================================================================
public class SpawnerScript : MonoBehaviour
{

    public GameObject YellowWithBlueWings;
    public GameObject WhiteWithRedWings;
    public GameObject Spaceship;
    public Spline yellowSpline;
    public Spline redSpline;
    public int enemiesPerWave;

    [SerializeField]
    private float timeBetweenEnemySpawn;

    [SerializeField]
    private float timeBetweenPlayerRespawn;

    public bool isPlayerAlive;



    // Start is called before the first frame update
    void Start()
    {
        spawnPlayer();
        StartCoroutine(spawnWaves()); 
    }

    void Update() 
    {
        if(!isPlayerAlive) {
            spawnPlayer();
        }
    }

    private IEnumerator spawnWaves() {
        for(int i = 0; i < enemiesPerWave; i++) 
        {
           GameObject yellowClone = Instantiate(YellowWithBlueWings);
           var enemyScript =  yellowClone.GetComponent<EnemyScript>();
           enemyScript.spline = yellowSpline;
           GameObject redClone = Instantiate(WhiteWithRedWings);
           enemyScript =  redClone.GetComponent<EnemyScript>();
           enemyScript.spline = redSpline;

           yield return new WaitForSeconds(timeBetweenEnemySpawn);
        }

    }

    private void spawnPlayer() {
        Spaceship = Instantiate(Spaceship);
        isPlayerAlive = true;
    }

}
