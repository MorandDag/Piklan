using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterPointsTrack : MonoBehaviour
{
    public int points = 0;
    public GameObject victoryWall;
    private void Update()
    {
        if (points == 73)
        {
            victoryWall.SetActive(false);
        }
    }
}
