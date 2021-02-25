using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuGameScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MenuExite;
    public GameObject MenuSave;
    [SerializeField] Animator animator;
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Submit") == 1)&&(animator.GetBool("pressed")))
        {
            MainMenu.SetActive(false);
            MenuSave.SetActive(true);
        }
    }
}
