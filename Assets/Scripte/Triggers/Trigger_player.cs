using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_player : MonoBehaviour
{
    private int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Track"))
        {
            Debug.Log("bb");
            point++;
        }

        if (other.CompareTag("Victory"))
        {
            Debug.Log("AA");
            if (point > 84)
            {
                Debug.Log("Victory");
                Application.LoadLevel(1);
            }
        }
    }
}
