using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    private Rigidbody rigidBody;
    protected Gun gun;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void Init(Gun gun)
    {
        this.gun = gun;
        Destroy(gameObject, lifeTime);
    }

    public void Launch()
    {
        Debug.Log("Launch");
        rigidBody.AddRelativeForce(Vector3.forward * gun.shootingForce, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ITakeDamage[] damageTakers = other.GetComponentsInChildren<ITakeDamage>();

        foreach (var dmgTaker in damageTakers)
        {
            dmgTaker.TakeDamage(gun, this, transform.position);
        }
    }

}
