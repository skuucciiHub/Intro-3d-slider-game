
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public PlayerMovement movement; // ref player movement 

     void OnCollisionEnter( UnityEngine.Collision collisionInfo) // when collision happens this function is called
    {
        /* if collider info name matches tag name collide indicator 
         this if stament will run */
        
        if (collisionInfo.collider.tag == "CI") 
                                                                                      
        {


            movement.enabled = false;
            FindObjectOfType<Manager>().gameOver();
            
        }
    }
}
