using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bastardoMovement : MonoBehaviour
{
    bool jump_key_pressed;
    bool goRight;
    bool goLeft;
    public bool grounded;
        void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        grounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)&& grounded)
        { 
            //Debug.Log("skok");
            //OnCollisionEnter(Collision);
            jump_key_pressed = true;
        }
        if (Input.GetKey(KeyCode.A) )
        {
            goLeft=true;
            //Debug.Log("lewo");
        }
        if(Input.GetKey(KeyCode.D))
        {
            goRight = true;
            //Debug.Log("Prawo");
        }
        
    }

    private void FixedUpdate()
    {
        
        if (jump_key_pressed)
        {
            //Debug.Log("skok");

            
            GetComponent<Rigidbody>().AddForce(Vector3.up * 8, ForceMode.VelocityChange);
            jump_key_pressed=false;
            grounded=false;
        }
        if (goRight)
        {
            GetComponent<Rigidbody>().AddForce((Vector3.right * 1)/2, ForceMode.VelocityChange);
            goRight = false;

        }
        if (goLeft)
        {
            GetComponent<Rigidbody>().AddForce((Vector3.left * 1)/2, ForceMode.VelocityChange);
            goLeft = false;
        }
    }   
}
