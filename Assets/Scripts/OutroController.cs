using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class OutroController : MonoBehaviour
{
    void Update()
    {
        // Check for "Space" key press.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            RestartGame();
        }
    }


    void RestartGame()
    {
        // Add logic to restart the game here.
        // For example, reload the current scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
