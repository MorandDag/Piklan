using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class PortalTest : MonoBehaviour
{
    public PortalTest portalExit;
    public bool port = true;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (port)
        {
            co.transform.position = portalExit.transform.position;
            portalExit.port = false;
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        this.port = true;
    }
}
