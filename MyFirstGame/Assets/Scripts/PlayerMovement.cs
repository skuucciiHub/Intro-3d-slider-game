
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //Refrence component
    public Rigidbody rb;
    

    //variables 
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public float jumpForce = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {
       
    rb.AddForce(0, 0, forwardForce  * Time.deltaTime);

        //if staments for player mov

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // force for d key 
            // velocity changed for faster key responce
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // force for a key 
            // velocity changed for faster key responce 
        }

        
         
        
        

        if(rb.position.y < -1f)
        {
            FindObjectOfType<Manager>().gameOver();
        }
    }
}
