using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger_victory : MonoBehaviour
{
    [SerializeField] CounterPointsTrack counterPointsTrack;
    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
                Application.LoadLevel(4);
        }
    }
}
