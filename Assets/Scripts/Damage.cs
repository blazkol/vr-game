using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Damage : MonoBehaviour, ITakeDamage
{
    private Rigidbody rigidBody;
    void Awake()
    {
       rigidBody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    public void TakeDamage(Gun gun, Projectile projectile, Vector3 contactPoint)
    {
        Debug.Log("Take Damage");
    }
}
