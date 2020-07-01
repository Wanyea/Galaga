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
    public Transform yellowBlue; 
    public Transform yellowBlue2;
    public Transform yellowBlue3;
    public Transform yellowBlue4;
    public Transform whiteRed;
    public Transform whiteRed2;
    public Transform whiteRed3;
    public Transform whiteRed4;

    Object yellowBlueObject;
    Object whiteRedObject;

    Object coord00;

    void Awake() 
    {
        //Initiate first wave of enemies. 
        spawnYellowEnemies();
        spawnWhiteEnemies();
            
    }

    //Start is called before the first frame. 
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        yellowBlueObject = Resources.Load("YellowWithBlueWings");
        yellowBlueObject = Resources.Load("YellowWithBlueWings2");
        yellowBlueObject = Resources.Load("YellowWithBlueWings3");
        yellowBlueObject = Resources.Load("YellowWithBlueWings4");
        whiteRedObject = Resources.Load("WhiteWithRedWings");
        whiteRedObject = Resources.Load("WhiteWithRedWings2");
        whiteRedObject = Resources.Load("WhiteWithRedWings3");
        whiteRedObject = Resources.Load("WhiteWithRedWings4");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

//TODO: Destroy/ Move / change animation of enemies when hit with "Blaster" game object.
    public void OnTriggerCollision2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Blaster"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }

//TODO: LERP to coordinate after enemies have finished their route on the spline. 
    public void spawnYellowEnemies() {
            Tween.Spline(yellowSpline, yellowBlue, 0, 1, false, 2, 0, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(yellowSpline, yellowBlue2, 0, 1, false, 2, 0.1f, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(yellowSpline, yellowBlue3, 0, 1, false, 2, 0.2f, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(yellowSpline, yellowBlue4, 0, 1, false, 2, 0.3f, Tween.EaseInOut, Tween.LoopType.None);
            //??: transform.position = Vector3.MoveTowards(coord00.x, coord00.y, 1.0f);

    }

    public void spawnWhiteEnemies(){
            Tween.Spline(redSpline, whiteRed, 0, 1, false, 2, 0, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(redSpline, whiteRed2, 0, 1, false, 2, 0.1f, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(redSpline, whiteRed3, 0, 1, false, 2, 0.2f, Tween.EaseInOut, Tween.LoopType.None);
            Tween.Spline(redSpline, whiteRed4, 0, 1, false, 2, 0.3f, Tween.EaseInOut, Tween.LoopType.None);
        
    }

}
