using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintTimberTriggers : MonoBehaviour
{
    public TimberForce timber;
    //public GameObject path;;

    void OnTriggerEnter2D(Collider2D co)
    {
        //Quaternion theRotation = timber.transform.localRotation;
        //Debug.Log(theRotation.z);
        //theRotation.z += 0.90f;
        //Debug.Log(theRotation);
        //timber.transform.localRotation = theRotation;
        //Debug.Log(timber.transform.localRotation);
        if ((co.gameObject.name == "Player") && (!timber.enemyCheck))
        {
            timber.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
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
