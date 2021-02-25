using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishStop : MonoBehaviour
{
    public Transform pointEnd;
    public Transform pointStart;

    public bool status;

    // Update is called once per frame
    

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.name.Contains("PointEnd"))
        {   status = true;
            this.gameObject.SetActive(false);
            this.gameObject.transform.position = pointStart.position;
        }
    }
}
