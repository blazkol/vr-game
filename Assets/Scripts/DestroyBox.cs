using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    public GameObject objectToAppear;
    public GameObject teleportToDestroy;
    private void OnDestroy()
    {
        Instantiate(objectToAppear, transform.position, transform.rotation);
        Destroy(teleportToDestroy);
    }
}
