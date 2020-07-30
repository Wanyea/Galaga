using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//================================================
//Enemy Blaster Script - Deals with enemy blaster 
//================================================


public class EnemyBlasterScript : MonoBehaviour
{
    [SerializeField]
    Vector2 EnemyBlasterForce = new Vector2(0, -10.0f);
    public GameplayScript gameplayScript;
    public bool isPlayerHit;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    Object enemyBlasterRef;

     void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>(); 
      gameplayScript = GetComponent<GameplayScript>();
      enemyBlasterRef = Resources.Load("EnemyBlaster"); 
    }

    void Update() 
    {
        rigidbody.velocity = EnemyBlasterForce;
    }


  public void destroyEnemyBlaster() {
    Destroy(GameObject.FindGameObjectWithTag("EnemyBlaster"), 2.0f);
  }
}
