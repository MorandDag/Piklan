using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            co.transform.parent = this.transform;
        }
    }

    //void OnTriggerExit2D(Collider2D co)
    //{
    //    if (co.name == "Player")
    //    {
    //        co.transform.parent = null;
    //    }
    //}
}
