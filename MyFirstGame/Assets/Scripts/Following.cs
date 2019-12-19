
using UnityEngine;

public class Following : MonoBehaviour
{
    // variables 
    public Transform player;

    // adding vector3 varible to add to x y z 
   public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // setting  cam object equal to player object then adding offset to follow player object 
        transform.position = player.position + offset;
    }
}
