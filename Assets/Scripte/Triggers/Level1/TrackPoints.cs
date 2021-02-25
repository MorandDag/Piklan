using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPoints : MonoBehaviour
{
    [SerializeField] CounterPointsTrack counterPointsTrack;
    public GameObject pointTrack;
    public bool pointTrackCheck = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(pointTrackCheck == false)
            {
                pointTrackCheck = true;
                counterPointsTrack.points++;
            }
        }
    }
}
