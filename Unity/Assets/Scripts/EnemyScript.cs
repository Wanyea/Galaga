using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Pixelplacement;
using UnityEngine;

//===========================================================
// Enemy Script – Deals with enemy movement and interactions
//===========================================================
public class EnemyScript : MonoBehaviour
{
   
    public SpawnerScript spawnerScript;
    public EnemyMovementScript enemyMovementScript;
    private Rigidbody2D rigidbody;
    private Animator animator;
    private Collider2D collision;
    public Spline spline;
    public Vector3 lastPosition;
    private GameObject spaceship;
    private GameObject blaster;
    public GameObject EnemyExplosion;
    public GameObject formation;
    public GameObject enemyDestroyedAudio;
    public float splineDuration = 2.0f;
    public float splineDelay = 0.0f;
    public float lerpDuration;
    public float lerpDelay; 
    public float maxTimer;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
        collision = GetComponent<Collider2D>();
        spawnerScript = GetComponent<SpawnerScript>();
        enemyMovementScript = GetComponent<EnemyMovementScript>();
 
        Tween.Spline(

        spline, gameObject.transform, 0.0f, 1.0f, false, 
        splineDuration, splineDelay ,  completeCallback: pathCompleted

        );
    
    }

    void Update()
    {
        Vector3 moveDirection = gameObject.transform.position - lastPosition;
            if(moveDirection != Vector3.zero) 
            {
            
                float angle = Mathf.Atan2(moveDirection.x, moveDirection.y) * Mathf.Rad2Deg;
                gameObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);

            }

        lastPosition = gameObject.transform.position;
    
    }



    void OnTriggerEnter2D(Collider2D collider) 
        {
            Instantiate(enemyDestroyedAudio, gameObject.transform.position, Quaternion.identity);
             Destroy(enemyDestroyedAudio, 5.0f);
        
            if(collider.gameObject.CompareTag("Blaster")) 
            {
             Destroy(gameObject);
             Instantiate(EnemyExplosion, gameObject.transform.position, Quaternion.identity);

                if(gameObject.CompareTag("yellowEnemy")) 
                {
                    ScoreManager.score += 100;
                } else if(gameObject.CompareTag("redEnemy")) {
                    ScoreManager.score += 50;
                }  else if(gameObject.CompareTag("greenEnemy")) {
                    ScoreManager.score += 250;
                }


            } else if(collider.gameObject.CompareTag("Player")) {
             Destroy(gameObject);  

            }

        }


    public void pathCompleted() 
    {
       //Tween.Position(gameObject.transform, formation.transform.position, lerpDuration,lerpDelay, Tween.EaseInOut);
    }
        

}
