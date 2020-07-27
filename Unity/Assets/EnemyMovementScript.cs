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
    public float lerpDuration;
    public float lerpDelay; 
    public List<GameObject> coordinates;

    void Update() 
    {
        enemyScript = GetComponent<EnemyScript>();
        spawnerScript = GetComponent<SpawnerScript>();

        coordinates = new List<GameObject>();
    }

    //Method that deals with enemy LERP after they have completed the spline.
    public void pathCompleted() 
    {
        
            Tween.Position(gameObject.transform, coordinates[0].transform.position, lerpDuration, lerpDelay, Tween.EaseInOut);
        } 

    }

