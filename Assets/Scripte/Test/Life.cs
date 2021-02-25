using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject player;
    public LifePlayer lifePlayer;
    public CheckpointTest[] checkpoint;
    public bool life = true;

    void Update()
    {
        if (life == false)
        {
            foreach(CheckpointTest check in checkpoint)
            {
                if (check.lastPoint)
                {
                    lifePlayer.life--;
                    player.transform.position = check.transform.position;
                    life = true;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            life = false;
        }
    }
}
