using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumplevel2 : MonoBehaviour
{

    // reference  

    public Rigidbody jV; // referencing to physics 
    public LayerMask groundLayers; // make sure what is a ground to step and jump on 
    public BoxCollider col; // refrencing collider of player 

    // varible for upward force
    
    public float jumpVelocity = 500f;
    // var for is grounded 
    public bool isGrounded = true;
    



   
    // Update is called once per frame

    void Update()
    {
        if(isGrounded == true && Input.GetKey(KeyCode.Space)) // calling funtion to check if on ground
        {
            jV.velocity = Vector3.up * jumpVelocity * Time.deltaTime; // Rather than a force applied up we our using a velocity taht affect upward motion
        }
    }

    private void OnCollisionEnter(Collision thecollision) // dectects if player is touching any object under tag name floor
    {
        if (thecollision.gameObject.tag == "floor") 
        isGrounded = true;
    }
    
    private void OnCollisionExit(Collision thecollision) // dectecting if player object has exit ground collision thus setting is ground to off
    {
        if (thecollision.gameObject.tag == "floor")

            isGrounded = false;
    }

    
}   
