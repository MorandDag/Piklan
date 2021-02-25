using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintTimberEnemy : MonoBehaviour
{
    public TimberForce timber;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name == "Enemy")
        {
            timber.enemyCheck = true;
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        if (co.gameObject.name == "Enemy")
        {
            timber.enemyCheck = false;
        }
    }
}
