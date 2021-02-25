using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class TimberBirdCatch : MonoBehaviour
{
    public GameObject birt;

    private void Update()
    {
        transform.position = birt.transform.position;
    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name == "Player")
        {
            co.transform.parent = this.transform;
            //co.transform.position = new Vector3(0, 0, 0);
            birt.GetComponent<AIPath>().enabled = false;
            birt.GetComponent<EnemyMove>().enabled = true;
            co.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
