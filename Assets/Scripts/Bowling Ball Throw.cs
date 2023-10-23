using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallThrow : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    bool HasClicked = false;
    Vector3 ScreenPosition;
    Vector3 WorldPosition;
    float force = 0;


    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        float h = Input.GetAxis("Horizontal");
        float speed = 0.5f;
        float horziontalMovement = h * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        { 
            force += 10;
        } else if (Input.GetKey(KeyCode.S))
        {
            force-= 10;
        }

        if (Input.GetKey(KeyCode.Space) && HasClicked == false)
        {
            rb.AddForce(0.0f, 0.0f, -force);
            HasClicked = true;
        }
        
        transform.Translate(horziontalMovement, 0.0f, 0.0f);
    }

    
}
