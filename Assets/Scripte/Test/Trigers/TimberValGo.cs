using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimberValGo : MonoBehaviour
{
    public GameObject timberVal;
    public GameObject timberBridge;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            timberVal.SetActive(false);
            this.gameObject.SetActive(false);
            timberBridge.SetActive(true);
        }
    }
}
