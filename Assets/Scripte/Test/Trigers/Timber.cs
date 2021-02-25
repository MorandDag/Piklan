using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timber : MonoBehaviour
{
    //[SerializeField] Life life;
    public GameObject pointStart;
    public float speed = 3f;
    public bool rigth;
    private void Update()
    {
        if (rigth)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
        
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name.Contains("StopPoint"))
        {
            transform.position = pointStart.transform.position;
        }

        //if (co.name == "Player")
        //{
        //    //co.GetComponent<Rigidbody2D>().centerOfMass = this.transform;
        //    co.transform.parent = this.transform;
        //}
    }

    
}
