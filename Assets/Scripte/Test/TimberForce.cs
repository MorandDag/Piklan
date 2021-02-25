using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimberForce : MonoBehaviour
{
    //public HingeJoint2D hingeJoint;
    public bool run;
    public bool enemyCheck = false;
    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.name == "Player")
        {
            run = true;
        }
    }
}
