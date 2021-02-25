using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimberBirtDrop : MonoBehaviour
{
    public GameObject birt;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name == "Player")
        {
            co.transform.parent = null;
            co.GetComponent<PlayerMovement>().enabled = true;
            var enemyMove = birt.GetComponent<EnemyMove>();
            enemyMove.pathPoint = 1;
            enemyMove.cur = 0;
        }
    }
}
