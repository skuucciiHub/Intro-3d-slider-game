
using UnityEngine;

public class ending : MonoBehaviour
{

   
   
    
    private void OnTriggerEnter() // detects trigger action 
    {
        FindObjectOfType<Manager>().completed();

    }
}
