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
    private GameObject spaceship;
    private GameObject blaster;
    public List<GameObject> coordinates;
    public GameObject enemy;
    public Transform followers;
    public float splineDuration = 2.0f;
    public float splineDelay = 0.0f;
    public float rotationDuration;
    public float rotationDelay;
    public bool enemyHit;
    public float maxTimer;
    public float turnAngle;

    //Object coord00;


    //Start is called before the first frame. 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
        collision = GetComponent<Collider2D>();
        spawnerScript = GetComponent<SpawnerScript>();
        enemyMovementScript = GetComponent<EnemyMovementScript>();

        coordinates = new List<GameObject>();    

        Tween.Spline(

        spline, gameObject.transform, 0.0f, 1.0f, false, 
        splineDuration, splineDelay, completeCallback: enemyMovementScript.pathCompleted

        );

        //TODO: get enemies to turn as they travel along the spline
        //      code below turns along z-axis but try to find a better way.
        //Tween.Rotation(gameObject.transform, new Vector3(0.0f, 0.0f, 0), rotationDuration, rotationDelay, Tween.EaseInOut);

            /* if(gameObject.tag == "redEnemy") {
                 turnAngle = -90;
                 maxTimer = 2;
                 StartCoroutine(rotateObject());
            } else if (gameObject.tag == "yellowEnemy") {
                turnAngle = 90;
                maxTimer = 2;
                StartCoroutine(rotateObject());
            }*/
        
        

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider) 
        {
            if(collider.gameObject.CompareTag("Blaster")) 
            {
             Destroy(gameObject);  
                if(gameObject.CompareTag("yellowEnemy")) 
                {
                    ScoreManager.score += 100;
                } else if(gameObject.CompareTag("redEnemy")) {
                    ScoreManager.score += 50;
                }   

            } else if(collider.gameObject.CompareTag("Player")) {
             Destroy(gameObject);    

            }

        }

private IEnumerator rotateObject()
     {
         float timer = 0f;
         while(timer <= maxTimer)
         {
             gameObject.transform.Rotate (new Vector3 (0, 0, turnAngle) * Time.deltaTime);
             timer +=Time.deltaTime;
             yield return null;
         }
     }
}
