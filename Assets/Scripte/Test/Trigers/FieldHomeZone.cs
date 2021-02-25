using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldHomeZone : MonoBehaviour
{
    public Enemy[] enemys;
    public int numberZone;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name == "Player")
        {
            foreach(var enemy in enemys)
            {
                enemy.searchPlayer = false;
                var enemyMove = enemy.GetComponent<EnemyMove>();
                enemyMove.pathPoint = numberZone;
            }
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        if (co.gameObject.name == "Player")
        {
            foreach (var enemy in enemys)
            {
                enemy.searchPlayer = true;
                var enemyMove = enemy.GetComponent<EnemyMove>();
                enemyMove.cur = 0;
            }
        }
    }
}
