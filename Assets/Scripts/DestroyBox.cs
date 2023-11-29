using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    public GameObject objectToAppear;
    public GameObject teleportToDestroy;
    private void OnDestroy()
    {
        Instantiate(objectToAppear, transform.position, transform.rotation);
        scoreCounter.AddScore(1);
        Destroy(teleportToDestroy);
    }
}
