using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : MonoBehaviour
{
    public int life;
    public GameObject player;

    void Update()
    {
        if(life <= 0)
        {
            Destroy(player);
        }
    }
}
