using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintForceColliders : MonoBehaviour
{
    public TimberForce timber;

    void OnTriggerEnter2D(Collider2D co)
    {
        timber.run = false;
        HingeJoint2D hinge = timber.GetComponent<HingeJoint2D>();
        var limits = hinge.limits;

        if (co.name == "Player")
        {
            if (this.name.Contains("1"))
            {
                limits.min = 270;
                limits.max = 360;
            }
            else if (this.name.Contains("2"))
            {
                limits.min = 0;
                limits.max = 90;
            }
            else if (this.name.Contains("3"))
            {
                limits.min = 180;
                limits.max = 90;
            }
            else if (this.name.Contains("4"))
            {
                limits.min = 180;
                limits.max = 270;
            }

            hinge.limits = limits;
            hinge.useLimits = true;
        }
    }
}
