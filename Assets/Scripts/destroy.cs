using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(objectToDestroy, 2f);
    }

  
}
