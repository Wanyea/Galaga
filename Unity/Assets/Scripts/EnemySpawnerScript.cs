using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
    public Transform YellowWithBlueWings;
    Object yellowBlueObject;
    Object whiteRedObject;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        yellowBlueObject = Resources.Load("YellowWithBlueWings");
        whiteRedObject = Resources.Load("WhiteWithRedWings");

        for(int i = 0; i < 4; i++) 
        {
           Instantiate(YellowWithBlueWings, new Vector3(3.0f , 9.0f , -6.0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
