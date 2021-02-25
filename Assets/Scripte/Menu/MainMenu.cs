using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        animator.SetBool("selected", true);
    }
}
