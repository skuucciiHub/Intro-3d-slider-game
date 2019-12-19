
using UnityEngine;
using UnityEngine.SceneManagement; // adding scene reload tools 

public class Manager : MonoBehaviour
{
    //refernce  to UI
    public GameObject completeUI;
    //variables 
    public bool ending = false; // setting ending to false
   

   // creating my game over function
    public void gameOver()
    {
        if(ending == false)
        {
            ending = true; // change to true to activate if stament once
            Debug.Log("GameOver");
          
            Invoke("Restart", 1f); // calling function restart with delayed time
            
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // geting current name of scene and reloading scene 
    }


   public void completed()
    {
        completeUI.SetActive(true); // when trigger box activated message will display
        Debug.Log("completed level");

    }
}
