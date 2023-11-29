using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class GameController : MonoBehaviour
{
   

    void Update()
    {
        // Check for "R" key press.
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }


    void RestartGame()
    {
        // Add logic to restart the game here.
        // For example, reload the current scene.
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}