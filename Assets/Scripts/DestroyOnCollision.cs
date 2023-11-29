using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
     // This method is called when the GameObject collides with another GameObject.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a specific tag or layer, if necessary.
        // Example: if (collision.gameObject.CompareTag("Enemy"))
        // Example: if (collision.gameObject.layer == LayerMask.NameToLayer("EnemyLayer"))
        
        // Destroy the GameObject.
        Debug.Log("logging");
        Destroy(gameObject);
    }
}
