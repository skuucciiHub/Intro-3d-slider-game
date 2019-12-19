using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour
{
    // reference 
    public Rigidbody rb;

    // force mutiplayers of grav for faster fall or slower fall depending on key press 
    public float fallMutiplier = 2.5f;
    public float slowFallMutiplier = 2f;
    
    

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMutiplier - 1) * Time.deltaTime;
        }
    }
}
