using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisappear : MonoBehaviour
{
    public float minDisappearTime = 3f;
    public float maxDisappearTime = 10f;

    void Start()
    {
        // Call the DisappearObject method after a random time interval
        float randomDisappearTime = Random.Range(minDisappearTime, maxDisappearTime);
        Invoke("DisappearObject", randomDisappearTime);
    }

    void DisappearObject()
    {
        // Destroy the gameObject this script is attached to
        Destroy(gameObject);
    }
}
