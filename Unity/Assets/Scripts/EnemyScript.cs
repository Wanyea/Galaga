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

    private Rigidbody2D rigidbody;
    private Animator animator;
    private Collider2D collision;
    public Spline spline;
    private GameObject spaceship;
    private GameObject blaster;
    public Transform followers;
    //public Transform completedDestination;
    public float duration = 2.0f;
    public float delay = 0.0f;
    public bool enemyHit;
    public int speed;

    //Object coord00;


    //Start is called before the first frame. 
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
        collision = GetComponent<Collider2D>();

        Tween.Spline(spline, gameObject.transform, 0.0f, 1.0f, false, duration, delay, completeCallback: pathCompleted);
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void pathCompleted() 
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
}

//TODO: LERP to coordinate after enemies have finished their route on the spline. 
