using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody; 

    [SerializeField]
    Vector2 BlasterForce = new Vector2(0, 20.0f);

    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(BlasterForce);
    }
}
