using UnityEngine.UI; // added UI 
using UnityEngine;

public class Distancetracker : MonoBehaviour
{
    /*refrence other objects position and getting postion info */

    public Transform player;
    public Text scoreText;
   

    // Update is called once per frame
    void Update()
    {
        //setting accessing physcial text from object scoretext 
        scoreText.text = player.position.z.ToString("00");
    }
}
