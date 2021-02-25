using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPointTimbers : MonoBehaviour
{
    public GameObject pointStart;
    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.name.Contains("Timber"))
        {
            co.transform.position = pointStart.transform.position;
        }
    }
}
