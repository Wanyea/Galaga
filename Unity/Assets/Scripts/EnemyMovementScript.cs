using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

//==================================================================
//Enemy Movement Script - Deals with enemy movement, post-spline.
//==================================================================

//TODO: LERP to coordinate after enemies have finished their route on the spline. 

public class EnemyMovementScript : MonoBehaviour {

    public EnemyScript enemyScript;
    public SpawnerScript spawnerScript;
    public GameObject[] coordinates;
    public float lerpDuration;
    public float lerpDelay; 
    
      
    void Start() 
    {
        enemyScript = GetComponent<EnemyScript>();
        spawnerScript = GetComponent<SpawnerScript>();
        


    }




    
//Tween.Position(spawnerScript.yellowGameObjects[i].transform, 3.0f, 0.0f, Tween.EaseInOut);
//Tween.Position(enemyScript.gameObject.transform, coordinates[i].transform.position, lerpDuration, lerpDelay, Tween.EaseInOut);
    
    
}


   
        






