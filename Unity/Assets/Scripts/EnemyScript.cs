using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

//===========================================================
// Enemy Script – Deals with enemy movement and interactions
//===========================================================
public class EnemyScript : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public Animator animator;
    public Collider2D collision;
    public Spline yellowSpline;
    public Spline redSpline;
    //Object coord00;

    void Awake() 
    {
        
    }

    //Start is called before the first frame. 
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
//TODO: Destroy/ Move / change animation of enemies when hit with "Blaster" game object.
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Blaster"))
        {
          Destroy(gameObject);
        }
            }
    }



/* 
//TODO: LERP to coordinate after enemies have finished their route on the spline. 
    public void spawnYellowEnemies() {
            //Tween.Spline(yellowSpline, yellowBlue, 0, 1, false, 2, 0, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(yellowSpline, yellowBlue2, 0, 1, false, 2, 0.1f, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(yellowSpline, yellowBlue3, 0, 1, false, 2, 0.2f, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(yellowSpline, yellowBlue4, 0, 1, false, 2, 0.3f, Tween.EaseInOut, Tween.LoopType.None);
        

    }

    public void spawnWhiteEnemies(){
            //Tween.Spline(redSpline, whiteRed, 0, 1, false, 2, 0, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(redSpline, whiteRed2, 0, 1, false, 2, 0.1f, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(redSpline, whiteRed3, 0, 1, false, 2, 0.2f, Tween.EaseInOut, Tween.LoopType.None);
            //Tween.Spline(redSpline, whiteRed4, 0, 1, false, 2, 0.3f, Tween.EaseInOut, Tween.LoopType.None);
        
    }

}
*/