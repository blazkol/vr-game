using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManekin : MonoBehaviour
{
    public GameObject objectToAppear;
    private void OnDestroy()
    {
        Instantiate(objectToAppear, transform.position, transform.rotation);
    }
}
