using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimberSummonBird : MonoBehaviour
{
    public GameObject bird;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            bird.SetActive(true);
        }
    }
}
