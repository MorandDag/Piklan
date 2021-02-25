using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintBirdThief : MonoBehaviour
{
    public GameObject colliders1;
    public GameObject colliders2;
    public LifePlayer life;
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            //var col = colliders1.GetComponent<Life>();
            //col.life = true;
            //col.enabled = false;

            colliders1.SetActive(false);
            colliders2.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D co)
    {
        if (co.name == "Player")
        {
            //var col = colliders1.GetComponent<Life>();
            //col.enabled = true;
            //col.life = true;

            colliders1.SetActive(true);
            colliders2.SetActive(true);

            life.life++;
        }
    }
}
