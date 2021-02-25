using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTest : MonoBehaviour
{
    public CheckpointTest[] checkpoint;
    public bool lastPoint;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (!this.lastPoint)
        {
            foreach(CheckpointTest chek in checkpoint)
            {
                chek.lastPoint = false;
            }
            this.lastPoint = true;
        }
    }
}
