using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintTimberTriggersRight : MonoBehaviour
{
    public TimberForce timber;
    

    void OnTriggerEnter2D(Collider2D co)
    {
        if ((co.gameObject.name == "Player") && (!timber.enemyCheck))
        {
            timber.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }        
    }

    void OnTriggerExit2D(Collider2D co)
    {
        if ((co.gameObject.name == "Player") && (!timber.enemyCheck))
        {
            AstarPath.active.Scan();
        }
    }

}
