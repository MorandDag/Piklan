using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_track : MonoBehaviour
{
    public GameObject obj;

    public Material mat1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {   
            transform.GetComponent<Renderer>().material = mat1;
            
        }
            
    }
}
