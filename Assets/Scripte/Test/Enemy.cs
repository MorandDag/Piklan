using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy : MonoBehaviour
{
    //public AIPath enemy;
    public bool searchPlayer = true;
    void Update()
    {
        if (!searchPlayer)
        {
            //enemy.enabled = false;
            this.GetComponent<AIPath>().enabled = false;
            this.GetComponent<EnemyMove>().enabled = true;
        }
        else
        {
            //enemy.enabled = true;
            this.GetComponent<AIPath>().enabled = true;
            this.GetComponent<EnemyMove>().enabled = false;
        }
    }
}
