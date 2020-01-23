﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;
    public Animator animator;
    
    void FixedUpdate () {
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position) {
            
            Vector2 p = Vector2.MoveTowards(transform.position,
                waypoints[cur].position,
                speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
        else cur = (cur + 1) % waypoints.Length;


        // Animation
        Vector2 dir = waypoints[cur].position - transform.position;
        animator.SetFloat("Horizontal", dir.x);
        animator.SetFloat("Vertical", dir.y);
        animator.SetFloat("Speed", dir.sqrMagnitude);
    }

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "Player")
            Destroy(co.gameObject);
    }
}
