using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public LifePlayer life;
    public CheckpointTest[] checkpoint;
    public Points[] points;
    public int pathPoint = 0;
    public int cur = 0;
    public float speed = 0.3f;
    public Animator animator;

    void FixedUpdate()
    {
        Transform[] waypoints = points[pathPoint].points;
        
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                waypoints[cur].position,
                speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else cur = (cur + 1) % waypoints.Length;

        Vector2 dir = waypoints[cur].position - transform.position;
        animator.SetFloat("Horizontal", dir.x);
        animator.SetFloat("Vertical", dir.y);
        animator.SetFloat("Speed", dir.sqrMagnitude);
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if ((co.name == "Player") && (this.name != "Bird"))
        {
            life.life--;

            foreach (CheckpointTest check in checkpoint)
            {
                if (check.lastPoint)
                {
                    co.transform.position = check.transform.position;
                }
            }
        }
    }
}
