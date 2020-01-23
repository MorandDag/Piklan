using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackVisible : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Player")
        {
            obj.SetActive(false);
        }
            
    }
}
