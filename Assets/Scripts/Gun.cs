using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] private Projectile bullet;
    [SerializeField] private Transform bulletSpawn;
    private Interactable interactable;

    public SteamVR_Action_Boolean fireAction;
    public float shootingForce;

    void Start()
    {
        interactable = GetComponent<Interactable>();
    }


    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Fire();
        }

        /*
        if(interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;

            if (fireAction[source].stateDown)
            {
                Fire();
            }
        }
        */
    }

    void Fire()
    {
        Debug.Log("Fire");
        Projectile projectileInstance = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
        projectileInstance.Init(this);
        projectileInstance.Launch();
    }
}
