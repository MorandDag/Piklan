using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movement;
    public float runSpeed = 5f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x + movement.x * runSpeed * Time.fixedDeltaTime, this.transform.position.y + movement.y * runSpeed * Time.fixedDeltaTime, 0);
    }
}
