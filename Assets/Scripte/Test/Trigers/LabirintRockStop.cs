using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintRockStop : MonoBehaviour
{
    public RockCheck rocks;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name.Contains("Rock"))
        {
            rocks.rockCheck++;
        }
    }
}
